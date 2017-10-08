﻿using System.Linq;
using static Barricades.Domaine.Position;

namespace Barricades.Domaine
{
  internal static class Plateaux
  {
    public static Trou[,] PlateauClassique()
    {
      var trous =  new Trou[10, 9];

      trous[9,0] = new Trou(P("9,0"));

      trous[8,4] = new Trou(P("8,4"), trous[9,0]);
      trous[8,3] = new Trou(P("8,3"), trous[8,4]);
      trous[8,2] = new Trou(P("8,2"), trous[8,3]);
      trous[8,1] = new Trou(P("8,1"), trous[8,2]);
      trous[8,0] = new Trou(P("8,0"), trous[8,1]);
      trous[8,5] = new Trou(P("8,5"), trous[8,4]);
      trous[8,6] = new Trou(P("8,6"), trous[8,5]);
      trous[8,7] = new Trou(P("8,7"), trous[8,6]);
      trous[8,8] = new Trou(P("8,8"), trous[8,7]);

      trous[7,0] = new Trou(P("7,0"), trous[8,0]);
      trous[7,1] = new Trou(P("7,1"), trous[7,0]);
      trous[7,2] = new Trou(P("7,2"), trous[7,1]);
      trous[7,3] = new Trou(P("7,3"), trous[7,2]);
      trous[7,7] = new Trou(P("7,7"), trous[8,8]);
      trous[7,6] = new Trou(P("7,6"), trous[7,7]);
      trous[7,5] = new Trou(P("7,5"), trous[7,6]);
      trous[7,4] = new Trou(P("7,4"), trous[7,5]);

      trous[6,0] = new Trou(P("6,0"), trous[7,3], trous[7,4]);

      trous[5,2] = new Trou(P("5,2"), trous[6,0]);
      trous[5,1] = new Trou(P("5,1"), trous[5,2]);
      trous[5,0] = new Trou(P("5,0"), trous[5,1]);
      trous[5,3] = new Trou(P("5,3"), trous[5,2]);
      trous[5,4] = new Trou(P("5,4"), trous[5,3]);

      trous[4,0] = new Trou(P("4,0"), trous[5,0]);
      trous[4,1] = new Trou(P("4,1"), trous[4,0]);
      trous[4,2] = new Trou(P("4,2"), trous[4,1], trous[5,1]);
      trous[4,3] = new Trou(P("4,3"), trous[4,2]);
      trous[4,7] = new Trou(P("4,7"), trous[5,4]);
      trous[4,6] = new Trou(P("4,6"), trous[4,7]);
      trous[4,5] = new Trou(P("4,5"), trous[4,6], trous[5,3]);
      trous[4,4] = new Trou(P("4,4"), trous[4,5]);


      trous[3,3] = new Trou(P("3,3"), trous[4,3], trous[4,4]);
      trous[3,2] = new Trou(P("3,2"), trous[3,3]);
      trous[3,1] = new Trou(P("3,1"), trous[3,2]);
      trous[3,0] = new Trou(P("3,0"), trous[3,1]);
      trous[3,4] = new Trou(P("3,4"), trous[3,3]);
      trous[3,5] = new Trou(P("3,5"), trous[3,4]);
      trous[3,6] = new Trou(P("3,6"), trous[3,5]);

      trous[2,0] = new Trou(P("2,0"), trous[3,0]);
      trous[2,2] = new Trou(P("2,2"), trous[3,1]);
      trous[2,1] = new Trou(P("2,1"), trous[2,0], trous[2,2]);
      trous[2,8] = new Trou(P("2,8"), trous[3,6]);
      trous[2,6] = new Trou(P("2,6"), trous[3,5]);
      trous[2,7] = new Trou(P("2,7"), trous[2,6], trous[2,8]);
      trous[2,3] = new Trou(P("2,3"));
      trous[2,4] = new Trou(P("2,4"));
      trous[2,5] = new Trou(P("2,5"));

      trous[1,0] = new Trou(P("1,0"), trous[2,1]);
      trous[1,1] = new Trou(P("1,1"), trous[2,1]);
      trous[1,2] = new Trou(P("1,2"), trous[2,3]);
      trous[1,3] = new Trou(P("1,3"), trous[2,3]);
      trous[1,4] = new Trou(P("1,4"), trous[2,5]);
      trous[1,5] = new Trou(P("1,5"), trous[2,5]);
      trous[1,6] = new Trou(P("1,6"), trous[2,7]);
      trous[1,7] = new Trou(P("1,7"), trous[2,7]);

      trous[0,0] = new Trou(P("0,0"));
      trous[0,1] = new Trou(P("0,1"));
      trous[0,2] = new Trou(P("0,2"));
      trous[0,3] = new Trou(P("0,3"));
      trous[0,4] = new Trou(P("0,4"));
      trous[0,5] = new Trou(P("0,5"));
      trous[0,6] = new Trou(P("0,6"));
      trous[0,7] = new Trou(P("0,7"));


      return trous;
    }
  }
}