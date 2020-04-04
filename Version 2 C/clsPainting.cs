using System;

namespace Version_2_C
{
    [Serializable()]
    public class ClsPainting : clsWork
    {
        private float _Width;
        private float _Height;
        private string _Type;

        public delegate void LoadPaintingFormDelegate(ClsPainting prPainting);
        public static LoadPaintingFormDelegate LoadPaintingForm;

        public override void EditDetails()
        {
            LoadPaintingForm(this);
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
