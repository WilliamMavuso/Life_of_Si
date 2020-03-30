using System;
namespace LifeofSi.Objects
{
    public class Si
    {

        const string SiStateKey = "SiState";
        const string SiXpKey = "SiXp";
        const string SiNameKey = "SiName";

        public int Xp
        {
            get
            {
                if (App.Current.Properties.ContainsKey(SiXpKey))
                {
                    Console.WriteLine((int)App.Current.Properties[SiXpKey]);
                    return (int)App.Current.Properties[SiXpKey];
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                App.Current.Properties[SiXpKey] = value;
            }
        }


        public SiState CurrentSiState
        {
            get
            {
                if (App.Current.Properties.ContainsKey(SiStateKey))
                {
                    return SiStates.GetSiState((string)App.Current.Properties[SiStateKey]);
                }
                else
                {
                    return SiState.stage1;
                }
            }
            set
            {
                App.Current.Properties[SiStateKey] = SiStates.GetSiString(value);

            }
        }
        public Si()
        {
        }

        public void FeedSi()
        {
            Xp = Xp + 500;
        }


    }
}
