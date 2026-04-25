﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryLoanSystem.Forms
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();

            if (IsDesignTime)
            {
                return;
            }

            LoadLogo();
        }

        private void LoadLogo()
        {
            string[] candidates =
            {
                Path.Combine(Application.StartupPath, "images", "marun_logo.png"),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "marun_logo.png"),
                Path.Combine("images", "marun_logo.png")
            };

            foreach (string path in candidates)
            {
                Image loadedImage = null;

                try
                {
                    if (!File.Exists(path))
                    {
                        continue;
                    }

                    using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (Image image = Image.FromStream(stream))
                    {
                        loadedImage = (Image)image.Clone();
                    }

                    if (picLogo.Image != null)
                    {
                        picLogo.Image.Dispose();
                    }

                    picLogo.Image = loadedImage;
                    return;
                }
                catch
                {
                    if (loadedImage != null)
                    {
                        loadedImage.Dispose();
                    }
                }
            }

            picLogo.Image = null;
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            new BooksForm().ShowDialog();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            new MembersForm().ShowDialog();
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            new LoansForm().ShowDialog();
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            new ReturnsForm().ShowDialog();
        }

        private void btnActiveLoans_Click(object sender, EventArgs e)
        {
            new ActiveLoansForm().ShowDialog();
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            new AuthorsForm().ShowDialog();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            new CategoriesForm().ShowDialog();
        }
    }
}
