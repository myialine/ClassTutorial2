using System;

namespace Version_2_C
{
    [Serializable()]
    public class ClsSculpture : clsWork
    {
        private float _Weight;
        private string _Material;

        public delegate void LoadSculptureFormDelegate(ClsSculpture prSculpture);
        public static LoadSculptureFormDelegate LoadSculpureForm;


        public override void EditDetails()
        {
            LoadSculpureForm(this);
        }

        public Single Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        public string Material
        {
            get { return _Material; }
            set { _Material = value; }
        }
    }
}
