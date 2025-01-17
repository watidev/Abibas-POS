﻿
#region USING
using System;
using System.ComponentModel;
#endregion

namespace TP3_420_14B_FX.classes
{
    /// <summary>
    /// Classe représentant les produits faisant patie d'une facture
    /// </summary>
    public class ProduitFacture 
    {
        #region CONSTANTES

        /// <summary>
        /// Quantité minimale
        /// </summary>
        public const uint QUANTITE_MIN_VAL = 1;

        /// <summary>
        /// Prix minimal 
        /// </summary>
        public const uint PRIX_MIN_VAL = 0;
        #endregion

        #region ATTRIBUTS

        /// <summary>
        /// Produit 
        /// </summary>
        private Produit _produit;

        /// <summary>
        /// Prix unitaire du produit
        /// </summary>
        private decimal _prixUnitaire;


        /// <summary>
        /// Quantité du produit acheté
        /// </summary>
        private uint _quantite;

        


        #endregion

        #region PROPRIÉTÉS ET INDEXEURS

        /// <summary>
        /// Obtient ou défini le produit à ajouter à la facture
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Lancée lorsque le produit est nul.</exception>
        public Produit Produit
        {
            get { return this._produit; }
            private set
            {
                //Todo : Implémenter la validation du produit FAIT
                if(value is null)
                    throw new ArgumentNullException("Produit");
                _produit = value;
            }
        }

        /// <summary>
        /// Obtient ou définit le prix unitaire du produit
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">Lancées lorsque le prix est inférieur ou égale à PRIX_MIN_VAL</exception>
        public decimal PrixUnitaire
        {
            get { return this._prixUnitaire; }
            set
            {
                //Todo : Implémenter la validation du prix unitaire FAIT
                if(value <= PRIX_MIN_VAL)
                    throw new ArgumentOutOfRangeException("Prix");
                _prixUnitaire = value;
            }
        }

        /// <summary>
        /// Obtient ou définit la quantité du produit achetée
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">Lancée lorsque la quantité est inférieur à QUANTITE_MIN_VAL.</exception>
        public uint Quantite
        {

            get { return this._quantite; }
            set
            {
                //Todo : Implémenter la validation de la quantité FAIT
                if(value < QUANTITE_MIN_VAL)
                    throw new ArgumentOutOfRangeException("Quantité");
                _quantite = value;
            }
        }

        /// <summary>
        /// Obtient le sous-total pour le produit selon le prix unitaire et la quantité achetée.
        /// </summary>
        public decimal SousTotal
        {
            get
            {
                //Todo : Implémenter le calcul du sous-total FAIT
                return PrixUnitaire * Quantite;
            }
        }

        #endregion

        #region CONSTRUCTEURS

        /// <summary>
        /// Constructeur avec paramètres
        /// </summary>
        /// <param name="produit">Produit à ajouter à la facture</param>
        /// <param name="prixUnitaire">Prix unitaire du produit</param>
        /// <param name="quantite">Quantité du produit</param>
        public ProduitFacture(Produit produit, decimal prixUnitaire, uint quantite)
        {
            //Todo : Implémenter le constructeur ProduitFacture
            Produit = produit;
            PrixUnitaire = prixUnitaire;
            Quantite = quantite;
        }

        #endregion

    }
}
