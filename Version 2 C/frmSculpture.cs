namespace Version_2_C
{
    public sealed partial class frmSculpture : frmWork
    {
        private frmSculpture()
        {
            InitializeComponent();
        }

        public static readonly frmSculpture Instance = new frmSculpture();

        public static void Run(ClsSculpture prSculpture)
        {
            Instance.SetDetails(prSculpture);
        }

        protected override void updateForm()
        {
            base.updateForm();
            ClsSculpture lcWork = (ClsSculpture)this._Work;
            txtWeight.Text = lcWork.Weight.ToString();
            txtMaterial.Text = lcWork.Material;
        }

        protected override void pushData()
        {
            base.pushData();
            ClsSculpture lcWork = (ClsSculpture)_Work;
            lcWork.Weight = float.Parse(txtWeight.Text);
            lcWork.Material = txtMaterial.Text;
        }
    }
}

