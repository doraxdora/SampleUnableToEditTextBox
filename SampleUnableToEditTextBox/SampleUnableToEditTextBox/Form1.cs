﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleUnableToEditTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// テキストボックス上のキャレットを制御.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textbox_caret_control(object sender, EventArgs e)
        {
            if (Cursor.Current != Cursors.Default)
            {
                Cursor.Current = Cursors.Default;
            }
            TextBox textbox = (TextBox)sender;
            textbox.Enabled = false;
            textbox.Enabled = true;
        }

        /// <summary>
        /// テキストボックス上のカーソルを制御.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textbox_cursor_control(object sender, EventArgs e)
        {
            if (Cursor.Current != Cursors.Default)
            {
                Cursor.Current = Cursors.Default;
            }
        }

        /// <summary>
        /// テキストボックス上のカーソルを制御.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textbox_cursor_control(object sender, MouseEventArgs e)
        {
            if (Cursor.Current != Cursors.Default)
            {
                Cursor.Current = Cursors.Default;
            }
        }

    }
}
