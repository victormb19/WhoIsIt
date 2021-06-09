using System;
using UnityEngine;
using UnityEngine.UIElements;
using WhoIsIt.Models;

namespace WhoIsIt.Views
{
    [Serializable]
    class MainView : View
    {
        StyleColor black = new StyleColor(new Color(0, 0, 0));
        StyleColor white = new StyleColor(new Color(1, 1, 1));
        StyleColor red = new StyleColor(new Color(200f/255f, 5f/255f, 2f/255f));

        Button motoGp;
        Button moto2;
        Button moto3;
        Button motoE;

        CategoryName categoryName;
        TextField txtNumber;
        Button btnFind;
        
        protected override void InitializeComponents()
        {
            motoGp = visualElement.Q<Button>("btnMotoGP");
            motoGp.RegisterCallback<ClickEvent>(ev => ClickMotoGp());

            moto2 = visualElement.Q<Button>("btnMoto2");
            moto2.RegisterCallback<ClickEvent>(ev => ClickMoto2());

            moto3 = visualElement.Q<Button>("btnMoto3");
            moto3.RegisterCallback<ClickEvent>(ev => ClickMoto3());

            motoE = visualElement.Q<Button>("btnMotoE");
            motoE.RegisterCallback<ClickEvent>(ev => ClickMotoE());

            txtNumber = visualElement.Q<TextField>("txtNumber");

            btnFind = visualElement.Q<Button>("btnFind");
            btnFind.RegisterCallback<ClickEvent>(ev => ClickFind());

            categoryName = CategoryName.MotoGP;
            SelectedColor(motoGp);
        }


        private void ClickMotoGp()
        {
            categoryName = CategoryName.MotoGP;
            SelectedColor(motoGp);
            UnselectedColor(moto2);
            UnselectedColor(moto3);
            UnselectedColor(motoE);
        }

        private void ClickMoto2()
        {
            categoryName = CategoryName.Moto2;
            UnselectedColor(motoGp);
            SelectedColor(moto2);
            UnselectedColor(moto3);
            UnselectedColor(motoE);
        }

        private void ClickMoto3()
        {
            categoryName = CategoryName.Moto3;
            UnselectedColor(motoGp);
            UnselectedColor(moto2);
            SelectedColor(moto3);
            UnselectedColor(motoE);
        }

        private void ClickMotoE()
        {
            categoryName = CategoryName.MotoE;
            UnselectedColor(motoGp);
            UnselectedColor(moto2);
            UnselectedColor(moto3);
            SelectedColor(motoE);
        }

        private void SelectedColor(Button button)
        {
            button.style.color = black;
            button.style.backgroundColor = white;
        }

        private void UnselectedColor(Button button)
        {
            button.style.color = white;
            button.style.backgroundColor = red;
        }

        private void ClickFind()
        {
            viewVisitor.Visit(this);
        }

        public SearchData GetSearchData()
        {
           return new SearchData(categoryName, int.Parse(txtNumber.text));
        }
    }
}