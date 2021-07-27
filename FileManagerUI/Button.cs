using System.Drawing;
using System.Windows.Forms;

namespace FileManagerUI {
    public class FMButton : Button {
        public FMButton() {
            // Prevent the button from drawing its own border
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            // Draw Border using color specified in Flat Appearance
            var pen = new Pen(FlatAppearance.BorderColor, 1);
            var rectangle = new Rectangle(0, 0, Size.Width - 1, Size.Height - 1);
            e.Graphics.DrawRectangle(pen, rectangle);
        }
    }
}
