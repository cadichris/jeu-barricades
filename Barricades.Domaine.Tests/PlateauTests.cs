﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Int32;
using static System.Linq.Enumerable;
using static Barricades.Domaine.Couleur;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Barricades.Domaine.Tests
{
  [TestClass]
  public class PlateauTests
  {
    private const int UN_COUP = 1;
    private static Pion Pion(Couleur couleur, int x, int y) => new Pion(couleur, new Position(x, y));

    public Position P(string coordonnees)
    {
      coordonnees = coordonnees.Replace(" ", "");
      return new Position(Parse(coordonnees.Split(',')[0]), Parse(coordonnees.Split(',')[1]));
    }

    [TestMethod]
    public void MetLePlateauEnPlace()
    {
      var plateau = new Plateau();
      plateau.AssertPions(Bleu, P("0,0"), P("0,1"), P("1,0"), P("1,1"));
      plateau.AssertPions(Vert, P("0,2"), P("0,3"), P("1,2"), P("1,3"));
      plateau.AssertPions(Jaune, P("0,4"), P("0,5"), P("1,4"), P("1,5"));
      plateau.AssertPions(Rouge, P("0,6"), P("0,7"), P("1,6"),P("1,7"));

      // Ligne 2
      foreach (var y in Range(0, 9))
        plateau.AssertTrouVide(P($"2,{y}"));

      // Ligne 3
      plateau.AssertTrouVide(P("3,0"), P("3,1"), P("3,2"), P("3,4"), P("3,5"), P("3,6"));
      plateau.AssertPions(Barricade, P("3,3"));
    }

    [TestMethod]
    public void PeutPrevoirUnDeplacementSimple()
    {
      var plateau = new Plateau();
      var position = new Position(1, 0);
      var trajets = plateau.TrajetsPour(position, 1);

      AreEqual(1, trajets.Count());
      AreEqual(2, trajets.First().Etapes.Count);
      AreEqual(new Position(2, 1), trajets.First().Arrivee);
    }

    [TestMethod]
    public void PeutDeplacerUnPion()
    {
      var plateau = new Plateau();
      var departDuBleu = new Position(1, 0);
      var trajetsUnique = plateau.TrajetsPour(departDuBleu, UN_COUP).First();

      plateau.Deplacer(plateau.PionSur(departDuBleu), trajetsUnique);

      AreEqual(Pion(Bleu, 2, 1), plateau.PionSur(new Position(2, 1)));
      IsNull(plateau[departDuBleu].Pion);
    }
  }

  public static class PlateauTestsExtensions
  {
    public static void AssertPions(this Plateau plateau, Couleur couleurAttendue, params Position [] positions)
    {
      foreach (var position in positions)
      {
        var pionAttendu = new Pion(couleurAttendue, position);
        AreEqual(pionAttendu, plateau.PionSur(position));
      }
    }

    public static void AssertTrouVide(this Plateau plateau, params Position [] positions)
    {
      foreach (var position in positions)
      {
        IsTrue(plateau[position].EstVide);
      }
    }
  }
}