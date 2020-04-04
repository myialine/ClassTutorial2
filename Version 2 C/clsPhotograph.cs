using System;

namespace Version_2_C
{
    [Serializable()]
    public class ClsPhotograph : clsWork
    {
        private float _Width;
        private float _Height;
        private string _Type;

        public delegate void LoadPhotographFormDelegate(ClsPhotograph prPhotograph);
        public static LoadPhotographFormDelegate LoadPhotographForm;

        public override void EditDetails()
        {
            LoadPhotographForm(this);
        }

        public Single Width
        {
            get { return _Width; }
            set { _Width = value; }
        }

        public Single Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
    }
}
