using DevExpress.XtraMap;
using System;
using System.Windows.Forms;

namespace TilesLoaded {
    public partial class Form1 : Form {
        int requestsCounter = 0;
        ImageLayer Layer { get { return (ImageLayer)mapControl1.Layers[0]; } }

        public Form1() {
            InitializeComponent();
            Layer.RequestDataLoading += Layer_RequestDataLoading;
            Layer.DataLoaded += Layer_DataLoaded;
        }

        void Layer_RequestDataLoading(object sender, EventArgs e) {
            requestsCounter++;
            UpdateProgressBar();
        }

        void Layer_DataLoaded(object sender, DataLoadedEventArgs e) {
            progressBar1.Value = 100;
            progressBar1.Visible = false;
            label1.Visible = false;
            requestsCounter = 0;
        }

        void UpdateProgressBar() {
            if (!progressBar1.Visible)
                progressBar1.Visible = true;
            if (!label1.Visible)
                label1.Visible = true;
            progressBar1.Value = (int)(100 * (requestsCounter - 1) / requestsCounter);
        }
    }
}
