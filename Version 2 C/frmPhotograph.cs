namespace Version_2_C
{
    public sealed partial class frmPhotograph : frmWork
    {
        private frmPhotograph()
        {
            InitializeComponent();
        }

        public static readonly frmPhotograph Instance = new frmPhotograph();

        public static void Run(ClsPhotograph prPhotograph)
        {
            Instance.SetDetails(prPhotograph);
        }

        protected override void updateForm()
        {
            base.updateForm();
            ClsPhotograph lcWork = (ClsPhotograph)this._Work;
            txtWidth.Text = lcWork.Width.ToString();
            txtHeight.Text = lcWork.Height.ToString();
            txtType.Text = lcWork.Type;
        }

        protected override void pushData()
        {
            base.pushData();
            ClsPhotograph lcWork = (ClsPhotograph)_Work;
            lcWork.Width = float.Parse(txtWidth.Text);
            lcWork.Height = float.Parse(txtHeight.Text);
            lcWork.Type = txtType.Text;
        }
    }
}

