using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Zad2_Mateusz_Moczarski
{
    public partial class Form1 : Form
    {
        FIP.FIP fip = new FIP.FIP();
        Bitmap bitmap;
        Image image;
        double zoom = 1;
        string path;
        private int x;
        private int y;
        private bool dragged;

        public Form1()
        {
            InitializeComponent();
            this.pictureBox.MouseWheel += ZoomMouse;
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|" + "All files (*.*)|*.*";
                    string file = openFileDialog1.FileName;
                    path = file;
                    Open(path);
                }
            } catch
            {
                toolStripStatusLabel1.Text = "Wybierz plik JPG BMP PNG!";
            }
        }

        private void Open(string image)
        {
            try
            {
                if (System.IO.Path.GetExtension(image) == ".bmp" || System.IO.Path.GetExtension(image) == ".png" || System.IO.Path.GetExtension(image) == ".jpg")
                {
                    path = image;
                    this.image = Image.FromFile(image);
                    Bitmap bmp = new Bitmap(this.image, Convert.ToInt32(pictureBox.Width * zoom), Convert.ToInt32(pictureBox.Height * zoom));
                    Graphics g = Graphics.FromImage(bmp);
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    pictureBox.Image = bmp;
                    this.image = bmp;
                    toolStripStatusLabel1.Text = "Otwarto: " + path;
                }
                else
                {
                    toolStripStatusLabel1.Text = "Wybierz plik JPG BMP PNG!";
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Problem z plikiem!" + ex;
            }
        }

        private void RotateToLeft(object sender, EventArgs e)
        {
            if (image != null)
            {
                image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox.Image = image;
            }
        }

        private void RotateToRight(object sender, EventArgs e)
        {
            if (image != null)
            {
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox.Image = image;
            }
        }

        private void ZoomMouse(object sender, MouseEventArgs e)
        {
            if(e.Delta > 0)
            {
                if (pictureBox.Image != null)
                {
                    if (zoom < 2) zoom += 0.05;
                    Open(path);
                }
            } else
            {
                if (pictureBox.Image != null)
                {
                    if (zoom > 0.5) zoom -= 0.05;
                    Open(path);
                }
            }
        }

        private void ZoomPlus(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                if (zoom < 3) zoom += 0.1;
                Open(path);
            }
        }

        private void ZoomMinus(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                if (zoom > 0.5) zoom -= 0.1;
                Open(path);
            }
        }

        private void ChangeSize(object sender, EventArgs e)
        {
            Open(path);
        }

        private void ImgDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            dragged = true;
            x = e.X;
            y = e.Y;
        }

        private void ImgMove(object sender, MouseEventArgs e)
        {
            if (!dragged || !(sender is PictureBox c)) return;
            c.Top = e.Y + c.Top - y;
            c.Left = e.X + c.Left - x;
        }

        private void ImgUp(object sender, MouseEventArgs e)
        {
            if (!(sender is PictureBox)) return;
            dragged = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Open(path);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox.Image.Save(sfd.FileName, format);
                }
                toolStripStatusLabel1.Text = "Zapisano w " + sfd.FileName;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Nie udało się zapisać obrazu!";
            }
        }

        private void buttonDetection_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
                Bitmap editedBitmap = fip.ImagePrewittFilterColor(bitmap);
                pictureBox.Image = editedBitmap;
                this.image = editedBitmap;
            } catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }

        private void buttonContrast_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
            Bitmap editedBitmap = fip.ContrastStretching(bitmap, 0, hScrollBarContrast.Value);
            pictureBox.Image = editedBitmap;
            this.image = editedBitmap;
            } catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
}

        private void buttonBrightness_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
            Bitmap editedBitmap = fip.ColorAccent(bitmap, 0, hScrollBarBrightness.Value);
            pictureBox.Image = editedBitmap;
            this.image = editedBitmap;
            } catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }

        private void buttonGamma_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
            Bitmap editedBitmap = fip.GammaCorrection(bitmap, hScrollBarGamma.Value);
            pictureBox.Image = editedBitmap;
            this.image = editedBitmap;
            } catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            try
            {
            bitmap = new Bitmap(pictureBox.Image);
            Bitmap editedBitmap = fip.Rotate(bitmap, (int)numericUpDownRotate.Value);
            pictureBox.Image = editedBitmap;
            this.image = editedBitmap;
            } catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }

        private void buttonSizeChange_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
                Bitmap editedBitmap = fip.Resize(bitmap, (int)numericUpDownWidth.Value, (int)numericUpDownHeight.Value);
                pictureBox.Image = editedBitmap;
                this.image = editedBitmap;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }

        private void buttonColorFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
                Bitmap editedBitmap = fip.ColorFiltration(bitmap, comboBoxFiltr.SelectedItem.ToString());
                pictureBox.Image = editedBitmap;
                this.image = editedBitmap;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }

        private void buttonBW_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
                Bitmap editedBitmap = fip.ToBlackwhite(bitmap, 64);
                pictureBox.Image = editedBitmap;
                this.image = editedBitmap;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }

        private void buttonG1_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
                Bitmap editedBitmap = fip.ToGreyscaleAVG(bitmap);
                pictureBox.Image = editedBitmap;
                this.image = editedBitmap;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }

        private void buttonG2_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
                Bitmap editedBitmap = fip.ToGreyscale(bitmap);
                pictureBox.Image = editedBitmap;
                this.image = editedBitmap;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }

        private void buttonG3_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
                Bitmap editedBitmap = fip.ToGreyscaleLightness(bitmap);
                pictureBox.Image = editedBitmap;
                this.image = editedBitmap;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }

        private void buttonHistogram_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
                Bitmap editedBitmap = fip.HistogramShift(bitmap, 45);
                pictureBox.Image = editedBitmap;
                this.image = editedBitmap;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }

        private void buttonHistEq_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
                Bitmap editedBitmap = fip.HistoramEqualization(bitmap);
                pictureBox.Image = editedBitmap;
                this.image = editedBitmap;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }

        private void buttonOil_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
                Bitmap editedBitmap = fip.OilPaint(bitmap, 5, 15);
                pictureBox.Image = editedBitmap;
                this.image = editedBitmap;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
                Bitmap editedBitmap = fip.Sketch(bitmap);
                pictureBox.Image = editedBitmap;
                this.image = editedBitmap;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }

        private void buttonBlur_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
                Bitmap editedBitmap = fip.Blurring(bitmap, 5, 5, 15);
                pictureBox.Image = editedBitmap;
                this.image = editedBitmap;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }

        private void buttonMedian_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
                Bitmap editedBitmap = fip.ImageMedianFilterColor(bitmap, 4);
                pictureBox.Image = editedBitmap;
                this.image = editedBitmap;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }

        private void buttonLinear_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
                Bitmap editedBitmap = fip.ImageFilterColor(bitmap, fip.LaplaceF1());
                pictureBox.Image = editedBitmap;
                this.image = editedBitmap;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }

        private void buttonLumination_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Image);
                Bitmap editedBitmap = fip.ImageSDROMFilterGS(bitmap);
                pictureBox.Image = editedBitmap;
                this.image = editedBitmap;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
        }
    }
}
