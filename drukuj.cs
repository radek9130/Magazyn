private void drukujbutton_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintImage);
            pd.Print();
        }

        void PrintImage(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;


            Rectangle bounds = new Rectangle(x, y, width, height);

            Bitmap img = new Bitmap(width, height);
            var wScale = e.MarginBounds.Width / (float)img.Width;
            var hScale = e.MarginBounds.Height / (float)img.Height;

            
            var scale = wScale < hScale ? wScale : hScale;

            
            e.Graphics.ScaleTransform(scale, scale);

            
            e.Graphics.DrawImage(img, 0, 0);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
