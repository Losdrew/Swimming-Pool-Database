using System.Drawing.Printing;
using System.Drawing;
using System;
using System.Collections.Generic;
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
            var leftMargin = 0;
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

                    var columnCount = _trainingsDataGridView.Columns.Count;
                    for (var i = 0; i < columnCount; i++)
                    {
                        if (!_trainingsDataGridView.Columns[i].Visible)
                        {
                            columnCount--;
                            continue;
                        }

                        e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                            new Rectangle((int)_columnLefts[i], topMargin,
                                (int)_columnWidths[i], _headerHeight));

                        e.Graphics.DrawRectangle(Pens.Black,
                            new Rectangle((int)_columnLefts[i], topMargin,
                                (int)_columnWidths[i], _headerHeight));

                        e.Graphics.DrawString(_trainingsDataGridView.Columns[i].HeaderText, 
                            _trainingsDataGridView.Columns[i].InheritedStyle.Font, Brushes.Black,
                            new RectangleF((int)_columnLefts[i], topMargin, 
                                (int)_columnWidths[i], _headerHeight), _stringFormat);
                    }

                    _isTopOfPage = false;
                    topMargin += _headerHeight;
                }

                var cellCount = row.Cells.Count;
                for (var i = 0; i < cellCount; i++)
                {
                    if (!row.Cells[i].Visible)
                    {
                        cellCount--;
                        continue;
                    }

                    if (row.Cells[i].FormattedValue != null)
                    {
                        e.Graphics.DrawString(row.Cells[i].FormattedValue.ToString(), row.Cells[i].InheritedStyle.Font, 
                            Brushes.Black, new RectangleF((int)_columnLefts[i], topMargin, (int)_columnWidths[i], cellHeight),
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
            var labelFont = new Font("Arial", 18, FontStyle.Bold);
            var dataFont = new Font("Arial", 18, FontStyle.Regular);

            const float spacing = 15;
            var headerLineHeight = headerFont.GetHeight() + spacing;
            var labelLineHeight = labelFont.GetHeight() + spacing;

            var headerFormat = new StringFormat(StringFormatFlags.NoClip);
            var labelFormat = new StringFormat(StringFormatFlags.NoClip);
            headerFormat.Alignment = StringAlignment.Center;

            var (x, y) = (e.MarginBounds.X, e.MarginBounds.Y + spacing);

            e.Graphics.DrawString("Картка відвідувача", headerFont, Brushes.Black, e.MarginBounds, headerFormat);
            y += headerLineHeight;

            var labelSize = e.Graphics.MeasureString("Назва абонемента:", labelFont, e.MarginBounds.Size, labelFormat);
            e.Graphics.DrawString("Назва абонемента:", labelFont, Brushes.Black, x, y);
            e.Graphics.DrawString(subscriptionName, dataFont, Brushes.Black, x + labelSize.Width + 1, y);
            y += labelLineHeight;

            labelSize = e.Graphics.MeasureString("ПІБ:", labelFont, e.MarginBounds.Size, labelFormat);
            e.Graphics.DrawString("ПIБ:", labelFont, Brushes.Black, x, y);
            e.Graphics.DrawString(lastName + " " + firstName + " " + middleName, dataFont, Brushes.Black,
                x + labelSize.Width + 1, y);
            y += labelLineHeight;

            labelSize = e.Graphics.MeasureString("Рівень підготовки:", labelFont, e.MarginBounds.Size, labelFormat);
            e.Graphics.DrawString("Рівень підготовки:", labelFont, Brushes.Black, x, y);
            e.Graphics.DrawString(preparationLevel, dataFont, Brushes.Black, x + labelSize.Width + 1, y);
            y += labelLineHeight;

            labelSize = e.Graphics.MeasureString("Дата початку дії:", labelFont, e.MarginBounds.Size, labelFormat);
            e.Graphics.DrawString("Дата початку дії:", labelFont, Brushes.Black, x, y);
            e.Graphics.DrawString(startDate.ToLongDateString(), dataFont, Brushes.Black, x + labelSize.Width + 1, y);
            y += labelLineHeight;

            labelSize = e.Graphics.MeasureString("Дата завершення дії:", labelFont, e.MarginBounds.Size, labelFormat);
            e.Graphics.DrawString("Дата завершення дії:", labelFont, Brushes.Black, x, y);
            e.Graphics.DrawString(expiryDate.ToLongDateString(), dataFont, Brushes.Black, x + labelSize.Width + 1, y);
        }
    }
}
