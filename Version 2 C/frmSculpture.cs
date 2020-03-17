namespace Version_2_C
{
    public sealed partial class frmSculpture : frmWork
    {
        private frmSculpture()
        {
            InitializeComponent();
        }

        public static readonly frmSculpture Instance = new frmSculpture();

        public static void Run(clsSculpture prSculpture)
        {
            Instance.SetDetails(prSculpture);
        }

        protected override void updateForm()
        {
            base.updateForm();
            clsSculpture lcWork = (clsSculpture)this._Work;
            txtWeight.Text = lcWork.Weight.ToString();
            txtMaterial.Text = lcWork.Material;
        }

        protected override void pushData()
        {
            base.pushData();
            clsSculpture lcWork = (clsSculpture)_Work;
            lcWork.Weight = float.Parse(txtWeight.Text);
            lcWork.Material = txtMaterial.Text;
        }
    }
}

