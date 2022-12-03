using System.Drawing.Printing;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Swimming_Pool_Database
{
    public class Print
    {
        private DataGridView _trainingsDataGridView;
        private bool _isFirstPage;
        private bool _isTopOfPage;
        private int _totalWidth;
        private int _headerHeight;
        private int _rowCount;
        private readonly List<float> _columnLefts = new List<float>();
        private readonly List<float> _columnWidths = new List<float>();
        private readonly StringFormat _stringFormat = new StringFormat
        {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Center,
            Trimming = StringTrimming.EllipsisCharacter
        };

        private readonly Font _headerFont = new Font("Arial", 14, FontStyle.Bold);

        public void BeginPrintClientTrainings(DataGridView trainingsDataGridView)
        {
            _trainingsDataGridView = trainingsDataGridView;
            _isFirstPage = _isTopOfPage = true;
            _totalWidth = _headerHeight = _rowCount = 0;
            _columnLefts.Clear();
            _columnWidths.Clear();

            foreach (DataGridViewColumn column in trainingsDataGridView.Columns)
            {
                if (column.Visible)
                {
                    _totalWidth += column.Width;
                }
            }
        }

        public void PrintClientTrainings(PrintPageEventArgs e)
        {
            var leftMargin = e.MarginBounds.Left;
            var topMargin = e.MarginBounds.Top;

            if (_isFirstPage)
            {
                foreach (DataGridViewColumn column in _trainingsDataGridView.Columns)
                {
                    if (!column.Visible)
                    {
                        continue;
                    }

                    var columnWidth = (int)Math.Floor(column.Width * e.MarginBounds.Width / (double)_totalWidth);

                    _headerHeight = (int)e.Graphics
                        .MeasureString(column.HeaderText, column.InheritedStyle.Font, columnWidth).Height + 11;

                    _columnLefts.Add(leftMargin);
                    _columnWidths.Add(columnWidth);
                    leftMargin += columnWidth;
                }
            }

            while (_rowCount <= _trainingsDataGridView.Rows.Count - 1)
            {
                var row = _trainingsDataGridView.Rows[_rowCount];

                var cellHeight = row.Height + 20;

                if (topMargin + cellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                {
                    _isTopOfPage = true;
                    _isFirstPage = false;
                    e.HasMorePages = true;
                    break;
                }

                if (_isTopOfPage)
                {
                    topMargin = e.MarginBounds.Top;

                    var headerSize = e.Graphics.MeasureString(
                        "Тренування клієнта " + _trainingsDataGridView.Rows[0].Cells[1].FormattedValue, _headerFont,
                        e.MarginBounds.Width);
                    e.Graphics.DrawString(
                        "Тренування клієнта " + _trainingsDataGridView.Rows[0].Cells[1].FormattedValue, _headerFont,
                        Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - headerSize.Height - 13);

                    var date = DateTime.Now.ToShortDateString();
                    var dateSize = e.Graphics.MeasureString(date, _headerFont, e.MarginBounds.Width);
                    e.Graphics.DrawString(date, _headerFont, Brushes.Black,
                        e.MarginBounds.Left + e.MarginBounds.Width - dateSize.Width,
                        e.MarginBounds.Top - headerSize.Height - 13);

                    var visibleColumns =
                        _trainingsDataGridView.Columns.Cast<DataGridViewColumn>().Where(x => x.Visible).ToList();

                    for (var i = 0; i < visibleColumns.Count; i++)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                            new Rectangle((int)_columnLefts[i], topMargin,
                                (int)_columnWidths[i], _headerHeight));

                        e.Graphics.DrawRectangle(Pens.Black,
                            new Rectangle((int)_columnLefts[i], topMargin,
                                (int)_columnWidths[i], _headerHeight));

                        e.Graphics.DrawString(visibleColumns[i].HeaderText, 
                            visibleColumns[i].InheritedStyle.Font, Brushes.Black,
                            new RectangleF((int)_columnLefts[i], topMargin, 
                                (int)_columnWidths[i], _headerHeight), _stringFormat);
                    }

                    _isTopOfPage = false;
                    topMargin += _headerHeight;
                }

                var visibleCells = row.Cells.Cast<DataGridViewCell>().Where(x => x.Visible).ToList();

                for (var i = 0; i < visibleCells.Count; i++)
                {
                    if (row.Cells[i].FormattedValue != null)
                    {
                        e.Graphics.DrawString(visibleCells[i].FormattedValue.ToString(),
                            visibleCells[i].InheritedStyle.Font,
                            Brushes.Black,
                            new RectangleF((int)_columnLefts[i], topMargin, (int)_columnWidths[i], cellHeight),
                            _stringFormat);
                    }

                    e.Graphics.DrawRectangle(Pens.Black,
                        new Rectangle((int)_columnLefts[i], topMargin, (int)_columnWidths[i], cellHeight));
                }

                _rowCount++;
                topMargin += cellHeight;
            }
        }

        public void PrintVisitorCard(PrintPageEventArgs e, string subscriptionName, string firstName, string lastName, 
            string middleName, string preparationLevel, DateTime startDate, DateTime expiryDate)
        {
            var headerFont = new Font("Arial", 30, FontStyle.Bold);
            var dateFont = new Font("Arial", 23, FontStyle.Bold);
            var labelFont = new Font("Arial", 18, FontStyle.Bold);
            var dataFont = new Font("Arial", 18, FontStyle.Regular);

            const float spacing = 15;
            var headerLineHeight = headerFont.GetHeight() + spacing;
            var labelLineHeight = labelFont.GetHeight() + spacing;

            var stringFormat = new StringFormat(StringFormatFlags.NoClip);

            (float x, float y) = (e.MarginBounds.X, e.MarginBounds.Y);

            e.Graphics.DrawString("Картка відвідувача", headerFont, Brushes.Black, x, y, stringFormat);

            var date = DateTime.Now.ToShortDateString();
            var dateSize = e.Graphics.MeasureString(date, dateFont, e.MarginBounds.Width);
            e.Graphics.DrawString(date, dateFont, Brushes.Black,
                e.MarginBounds.Left + e.MarginBounds.Width - dateSize.Width, y + 10, stringFormat);

            y += headerLineHeight + spacing;

            var labelSize = e.Graphics.MeasureString("Назва абонемента:", labelFont, e.MarginBounds.Size, stringFormat);
            e.Graphics.DrawString("Назва абонемента:", labelFont, Brushes.Black, x, y);
            e.Graphics.DrawString(subscriptionName, dataFont, Brushes.Black, x + labelSize.Width + 1, y);
            y += labelLineHeight;

            labelSize = e.Graphics.MeasureString("ПІБ:", labelFont, e.MarginBounds.Size, stringFormat);
            e.Graphics.DrawString("ПIБ:", labelFont, Brushes.Black, x, y);
            e.Graphics.DrawString(lastName + " " + firstName + " " + middleName, dataFont, Brushes.Black,
                x + labelSize.Width + 1, y);
            y += labelLineHeight;

            labelSize = e.Graphics.MeasureString("Рівень підготовки:", labelFont, e.MarginBounds.Size, stringFormat);
            e.Graphics.DrawString("Рівень підготовки:", labelFont, Brushes.Black, x, y);
            e.Graphics.DrawString(preparationLevel, dataFont, Brushes.Black, x + labelSize.Width + 1, y);
            y += labelLineHeight;

            labelSize = e.Graphics.MeasureString("Дата початку дії:", labelFont, e.MarginBounds.Size, stringFormat);
            e.Graphics.DrawString("Дата початку дії:", labelFont, Brushes.Black, x, y);
            e.Graphics.DrawString(startDate.ToLongDateString(), dataFont, Brushes.Black, x + labelSize.Width + 1, y);
            y += labelLineHeight;

            labelSize = e.Graphics.MeasureString("Дата завершення дії:", labelFont, e.MarginBounds.Size, stringFormat);
            e.Graphics.DrawString("Дата завершення дії:", labelFont, Brushes.Black, x, y);
            e.Graphics.DrawString(expiryDate.ToLongDateString(), dataFont, Brushes.Black, x + labelSize.Width + 1, y);
        }
    }
}
