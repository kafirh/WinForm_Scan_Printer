﻿using PrintPackingLabel.Model;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;

namespace PrintPackingLabel.Presenter
{
    public class PrintPackingLabelLayout
    {
        private static readonly Dictionary<char, string> c39Pattern = new Dictionary<char, string>
        {
            {'0', "bwbWBwBwb"}, {'1', "BwbWbwbwB"}, {'2', "bwBWbwbwB"}, {'3', "BwBWbwbwb"},
            {'4', "bwbWBwbwB"}, {'5', "BwbWBwbwb"}, {'6', "bwBWBwbwb"}, {'7', "bwbWbwBwB"},
            {'8', "BwbWbwBwb"}, {'9', "bwBWbwBwb"}, {'A', "BwbwbWbwB"}, {'B', "bwBwbWbwB"},
            {'C', "BwBwbWbwb"}, {'D', "bwbwBWbwB"}, {'E', "BwbwBWbwb"}, {'F', "bwBwBWbwb"},
            {'G', "bwbwbWBwB"}, {'H', "BwbwbWBwb"}, {'I', "bwBwbWBwb"}, {'J', "bwbwBWBwb"},
            {'K', "BwbwbwbWB"}, {'L', "bwBwbwbWB"}, {'M', "BwBwbwbWb"}, {'N', "bwbwBwbWB"},
            {'O', "BwbwBwbWb"}, {'P', "bwBwBwbWb"}, {'Q', "bwbwbwBWB"}, {'R', "BwbwbwBWb"},
            {'S', "bwBwbwBWb"}, {'T', "bwbwBwBWb"}, {'U', "BWbwbwbwB"}, {'V', "bWBwbwbwB"},
            {'W', "BWBwbwbwb"}, {'X', "bWbwBwbwB"}, {'Y', "BWbwBwbwb"}, {'Z', "bWBwBwbwb"},
            {'-', "bWbwbwBwB"}, {'.', "BWbwbwBwb"}, {' ', "bWBwbwBwb"}, {'*', "bWbwBwBwb"},
            {'$', "bWbWbWbwb"}, {'/', "bWbWbwbWb"}, {'+', "bWbwbWbWb"}, {'%', "bwbWbWbWb"}
        };
        public void PrintBarcode(PrintPageEventArgs e, GaransiModel garansi)
        {
            PaperSize customPaperSize = new PaperSize("Custom", 276, 157);
            e.PageSettings.PaperSize = customPaperSize;

            int xPos = 24;
            int yPos = 12;

            Font fontTitle = new Font("PudHinban M", 11, FontStyle.Bold);
            Font fontBarcodeLabel = new Font("PudHinban M", 6, FontStyle.Regular);

            // Menampilkan barcode untuk Model Number
            using (Bitmap barcodeModel = GenerateBarcodeManual(garansi.ModelNumber))
            {
                e.Graphics.DrawImage(barcodeModel, new PointF(xPos, yPos));
                yPos += barcodeModel.Height - 38;

                var sizeLabel = e.Graphics.MeasureString("MODEL NO.", fontBarcodeLabel);
                e.Graphics.DrawString("MODEL NO.", fontBarcodeLabel, Brushes.Black, new PointF(xPos, yPos));
                e.Graphics.DrawString(garansi.ModelNumber, fontTitle, Brushes.Black, new PointF(xPos + sizeLabel.Width, yPos - 2));
            }

            yPos += (int)e.Graphics.MeasureString(garansi.ModelNumber, fontTitle).Height - 3;

            // Menampilkan barcode untuk Serial Number
            using (Bitmap barcodeSerial = GenerateBarcodeManual(garansi.modelCode+garansi.NoSeri))
            {
                e.Graphics.DrawImage(barcodeSerial, new PointF(xPos, yPos));
                yPos += barcodeSerial.Height - 38;

                var sizeLabel = e.Graphics.MeasureString("SERIAL NO.", fontBarcodeLabel);
                e.Graphics.DrawString("SERIAL NO.", fontBarcodeLabel, Brushes.Black, new PointF(xPos, yPos));
                e.Graphics.DrawString(garansi.NoSeri, fontTitle, Brushes.Black, new PointF(xPos + sizeLabel.Width, yPos - 2));
            }
        }

        public void PrintQRcode(PrintPageEventArgs e, GaransiModel garansi)
        {
            // Ukuran kertas custom
            PaperSize customPaperSize = new PaperSize("Custom", 276, 157);
            e.PageSettings.PaperSize = customPaperSize;

            int xPos = 12; // Posisi awal QR Code
            int yPos = 32;

            Font fontTitle = new Font("PudHinban M", 11, FontStyle.Bold);
            Font fontBarcodeLabel = new Font("PudHinban M", 6, FontStyle.Regular);

            // Generate QR Code untuk Model Number & Serial Number
            using (Bitmap barcodeModel = GenerateQRCode(garansi.NoSeri + "," + garansi.ModelNumber))
            {
                // Gambar QR Code di posisi awal
                e.Graphics.DrawImage(barcodeModel, new PointF(xPos-2, yPos-8));
                MessageBox.Show(barcodeModel.Width.ToString());

                // Geser xPos untuk menempatkan teks di samping QR Code
                xPos += barcodeModel.Width - 114; // Tambahkan jarak agar tidak terlalu dekat

                // Hitung ukuran teks agar bisa diatur posisinya dengan rapi
                float labelHeight = e.Graphics.MeasureString("MODEL NO.", fontBarcodeLabel).Height;
                float valueHeight = e.Graphics.MeasureString(garansi.ModelNumber, fontTitle).Height;
                float serialLabelHeight = e.Graphics.MeasureString("SERIAL NO.", fontBarcodeLabel).Height;
                float serialValueHeight = e.Graphics.MeasureString(garansi.NoSeri, fontTitle).Height;

                // Tampilkan teks di samping QR Code
                e.Graphics.DrawString("MODEL NO.", fontBarcodeLabel, Brushes.Black, new PointF(xPos, yPos+2));
                e.Graphics.DrawString(garansi.ModelNumber, fontTitle, Brushes.Black, new PointF(xPos-1, yPos + labelHeight-1));

                e.Graphics.DrawString("SERIAL NO.", fontBarcodeLabel, Brushes.Black, new PointF(xPos, yPos + labelHeight + valueHeight + 6));
                e.Graphics.DrawString(garansi.NoSeri, fontTitle, Brushes.Black, new PointF(xPos-1, yPos + labelHeight + valueHeight + serialLabelHeight+4));
                MessageBox.Show(garansi.NoSeri + "," + garansi.ModelNumber);
            }
        }


        private Bitmap GenerateQRCode(string data)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Height = 200, // Ukuran QR Code (pixel)
                    Width = 200,
                    PureBarcode = true,
                },
                Renderer = new BitmapRenderer() // Renderer untuk output Bitmap
            };
            Bitmap barcode = writer.Write(data);
            barcode.SetResolution(203, 203);
            return barcode;
        }

        private Bitmap GenerateBarcodeManual(string data)
        {
            // Pastikan semua karakter valid
            string barcodeData = "*" + data.ToUpper() + "*";
            System.Diagnostics.Debug.WriteLine($"Generated Barcode Data: {barcodeData}");

            if (!barcodeData.All(c => c39Pattern.ContainsKey(c)))
            {
                throw new ArgumentException("Data contains invalid characters for Code 39.");
            }

            // Mengonversi karakter menjadi pola barcode sesuai Code 39
            string barcodePattern = string.Join("w", barcodeData.Select(c => c39Pattern[c]));
            System.Diagnostics.Debug.WriteLine($"Generated Barcode Pattern: {barcodePattern}");

            // Parameter barcode
            float paperWidth = 480;
            float unitWidth = 2f;  // Satuan dasar untuk narrow bar
            int wideFactor = 3; // Faktor lebar untuk wide bar
            int barHeight = 80; // Tinggi barcode
            float totalWidth = barcodeData.Length*unitWidth*(3*wideFactor + 6) + (barcodeData.Length)*unitWidth; // Total lebar barcode

            if (totalWidth > paperWidth)
            {
                float scaleFactor = paperWidth / totalWidth;
                unitWidth *= scaleFactor;
                unitWidth = (float)Math.Floor(unitWidth * 10) / 10;
                System.Diagnostics.Debug.WriteLine($"Final Barcode floor: {unitWidth}");
                if (unitWidth < 1.1f)
                {
                    unitWidth = 1f;
                    System.Diagnostics.Debug.WriteLine($"Final Barcode unit 1: {unitWidth}");
                }
                totalWidth = barcodeData.Length*unitWidth*(3*wideFactor + 6) + (barcodeData.Length)*unitWidth; 
            }
            decimal unitWidthDecimal = (decimal)unitWidth;

            // Buat bitmap untuk barcode
            Bitmap barcode = new Bitmap((int)Math.Ceiling(totalWidth), barHeight);
            barcode.SetResolution(203, 203);
            using (Graphics g = Graphics.FromImage(barcode))
            {
                g.Clear(Color.White);
                decimal x = 0m;

                foreach (char c in barcodePattern)
                {
                    decimal barWidth = (char.IsUpper(c) ? wideFactor : 1) * unitWidthDecimal;
                    Brush brush = (char.ToLower(c) == 'b') ? Brushes.Black : Brushes.White;

                    // Konversi hanya saat menggambar
                    g.FillRectangle(brush, (float)x, 0, (float)barWidth, barHeight);
                    x += barWidth;
                }
                
                System.Diagnostics.Debug.WriteLine($"Final Barcode x: {x}");
            }

            // Debugging
            System.Diagnostics.Debug.WriteLine($"Final Barcode Width: {totalWidth}");

            return barcode;
        }


    }
}
