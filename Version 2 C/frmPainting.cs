namespace Version_2_C
{
    public sealed partial class frmPainting : frmWork
    {
        private frmPainting()
        {
            InitializeComponent();
        }

        public static readonly frmPainting Instance = new frmPainting();

        public static void Run(ClsPainting prPainting)
        {
            Instance.SetDetails(prPainting);
        }
        

        protected override void updateForm()
        {
            base.updateForm();
            ClsPainting lcWork = (ClsPainting)_Work;
            txtWidth.Text = lcWork.Width.ToString();
            txtHeight.Text = lcWork.Height.ToString();
            txtType.Text = lcWork.Type;
        }

        protected override void pushData()
        {
            base.pushData();
            ClsPainting lcWork = (ClsPainting)_Work;
            lcWork.Width = float.Parse(txtWidth.Text);
            lcWork.Height = float.Parse(txtHeight.Text);
            lcWork.Type = txtType.Text;
        }

    }
}

