using System;
namespace LifeofSi.Objects
{
    public class Cocoon
    {
        const string cocoonStateKey = "cocoonState";
        const string cocoonXpKey = "cocoonXp";
        const string cocoonNameKey = "cocoonName";

        public int Xp
        {
            get
            {
                if (App.Current.Properties.ContainsKey(cocoonXpKey))
                {
                    Console.WriteLine((int)App.Current.Properties[cocoonXpKey]);
                    return (int)App.Current.Properties[cocoonXpKey];
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                App.Current.Properties[cocoonXpKey] = value;
            }
        }


        public CocoonState CurrentCocoonState
        {
            get
            {
                if (App.Current.Properties.ContainsKey(cocoonStateKey))
                {
                    return CocoonStates.GetCocoonState((string)App.Current.Properties[cocoonStateKey]);
                }
                else
                {
                    return CocoonState.stage1;
                }
            }
            set
            {
                App.Current.Properties[cocoonStateKey] = CocoonStates.GetCocoonString(value);

            }
        }

 


        public Cocoon()
        {
        }
    }
}
