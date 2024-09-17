using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    class Building
    {
        public int _coordonneeX;
        public int _coordonneeY;
        public int _Largeur;
        public int _Profondeur;

        private Pen droneBrush = new Pen(new SolidBrush(Color.Purple), 3);

        public Building(int coordonneeX , int coordonneeY , int Largeur, int Profondeur ) 
        {
            this._coordonneeX = coordonneeX;
            this._Largeur = Largeur;
            this._coordonneeY = coordonneeY;
            this._Profondeur = Profondeur;
                
        }

        public void Renders(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(droneBrush, new Rectangle(_Largeur - 4, _Profondeur - 2, 8, 8));
            drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, _Largeur + 5, _Profondeur - 5);
        }

    }
}
