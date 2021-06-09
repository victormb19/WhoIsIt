using System;
using UnityEngine;
using UnityEngine.UIElements;
using WhoIsIt.Controllers;
using WhoIsIt.Models;

namespace WhoIsIt.Views
{
    class RiderView : View
    {
        VisualElement riderImage;

        Label lblName;
        Label lblNumber;
        Label lblTeam;
        Label lblBike;
        VisualElement countryImage;
        Label lblPlaceOfBirth;

        Button btnGoBack;


        SearchRiderController searchRiderController;

        protected override void InitializeComponents()
        {
            riderImage = visualElement.Q<VisualElement>("veRiderImage");
            btnGoBack = visualElement.Q<Button>("btnGoBack");
            lblName = visualElement.Q<Label>("lblName");
            lblNumber = visualElement.Q<Label>("lblNumber");
            lblTeam = visualElement.Q<Label>("lblTeam");
            lblBike = visualElement.Q<Label>("lblBike");
            countryImage = visualElement.Q<VisualElement>("veCountryImage");
            lblPlaceOfBirth = visualElement.Q<Label>("lblBirthPlace");

            btnGoBack.RegisterCallback<ClickEvent>(ev => GoBack());

            searchRiderController = new SearchRiderController();
        }

        public void Draw(SearchData searchData)
        {
            Rider rider = searchRiderController.Execute(searchData);
            string path = "Images/Riders/" + searchData.GetCategory().ToString() + "/" + rider.GetName().Replace(" ", String.Empty);
            Texture2D riderimage = Resources.Load(path) as Texture2D;
            riderImage.style.backgroundImage = new StyleBackground(riderimage);
            lblName.text = rider.GetName();
            lblNumber.text = rider.GetNumber();
            lblTeam.text = rider.GetTeam();
            lblBike.text = rider.GetBike();
            Texture2D flag = Resources.Load("Images/Flags/" + rider.GetCountry()) as Texture2D;
            countryImage.style.backgroundImage = new StyleBackground(flag);
            lblPlaceOfBirth.text = rider.GetPlaceOfBirth();
        }

        private void GoBack()
        {
            viewVisitor.Visit(this);
        }

    }
}