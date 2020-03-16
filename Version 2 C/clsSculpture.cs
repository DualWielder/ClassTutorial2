using System;

namespace Version_2_C
{
    [Serializable()]
    public class clsSculpture : clsWork
    {
        private float _Weight;
        private string _Material;

        [NonSerialized()]
        private static frmSculpture _SculptureDialog;

        public override void EditDetails()
        {
            if (_SculptureDialog == null)
                _SculptureDialog = frmSculpture.Instance;
            _SculptureDialog.SetDetails(this);
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
