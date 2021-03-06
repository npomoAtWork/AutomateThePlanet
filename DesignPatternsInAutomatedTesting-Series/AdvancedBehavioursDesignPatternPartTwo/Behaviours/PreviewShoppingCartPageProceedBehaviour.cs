﻿// <copyright file="PreviewShoppingCartPageProceedBehaviour.cs" company="Automate The Planet Ltd.">
// Copyright 2016 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>http://automatetheplanet.com/</site>

using AdvancedBehavioursDesignPatternPartTwo.Pages.PreviewShoppingCartPage;
using AdvancedBehavioursDesignPatternPartTwo.Pages.SignInPage;
using Microsoft.Practices.Unity;

namespace AdvancedBehavioursDesignPatternPartTwo.Behaviours
{
    public class PreviewShoppingCartPageProceedBehaviour : AdvancedBehavioursDesignPatternPartTwo.Behaviours.Core.WaitableActionBehaviour
    {
        private readonly PreviewShoppingCartPage previewShoppingCartPage;
        private readonly SignInPage signInPage;

        public PreviewShoppingCartPageProceedBehaviour()
        {
            this.previewShoppingCartPage = AdvancedBehavioursDesignPatternPartTwo.Base.UnityContainerFactory.GetContainer().Resolve<PreviewShoppingCartPage>();
            this.signInPage = AdvancedBehavioursDesignPatternPartTwo.Base.UnityContainerFactory.GetContainer().Resolve<SignInPage>(); 
        }

        protected override void PerformAct()
        {
            this.previewShoppingCartPage.ClickProceedToCheckoutButton();
        }

        protected override void PerformPostActWait()
        {
            this.signInPage.WaitForPageToLoad();
        }
    }
}