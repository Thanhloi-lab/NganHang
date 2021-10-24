using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NganHang.UndoRedo
{
    public class UndoRedoControl
    {
        string name;
        string text;
        bool check;
        int index;

        public UndoRedoControl(string name, string text)
        {
            this.name = name;
            this.text = text;
        }

        public UndoRedoControl(string name, bool isCheck)
        {
            this.name = name;
            this.check = isCheck;
        }

        public UndoRedoControl(string name, int index)
        {
            this.name = name;
            this.index = index;
        }

        public UndoRedoControl()
        {

        }

        public string Name { get => name; set => name = value; }
        public string Text { get => text; set => text = value; }
        public bool Check { get => check; set => check = value; }
        public int Index { get => index; set => index = value; }
    }
}
