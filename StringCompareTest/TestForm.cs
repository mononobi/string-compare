using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StringCompareTest
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            StringCompare sc = new StringCompare(Convert.ToInt32(cntSimilarity.Value), Convert.ToInt32(cntSimilarityShort.Value), Convert.ToInt32(cntTolerance.Value), Convert.ToInt32(cntToleranceShort.Value));

            double similarity = 0;
            double tolerance = 0;
            bool result = sc.IsEqual(txt1.Text, txt2.Text, out similarity, out tolerance);

            /*
             * you can use sc.IsEqual(text1, text2) if you don't need to know the similarity and tolerance between two strings
             */

            lblSimilarity.Text = "Similarity: " + Convert.ToInt32(similarity).ToString() + "%";
            lblTolerance.Text = "Tolerance: " + Convert.ToInt32(tolerance).ToString() + "%";

            if (result == true)
            {
                lblResult.Text = "Equal";
            }
            else
            {
                lblResult.Text = "Not Equal";
            }
        }
    }
}
