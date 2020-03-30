using System;
namespace LifeofSi.Objects
{

    public enum CocoonState
    {
        stage1,
        stage2,
        stage3
    }


    class CocoonStates
    {
        public static string GetCocoonString(CocoonState cocoonState)
        {
            switch (cocoonState)
            {
                case CocoonState.stage1:
                    return "stage1";
                case CocoonState.stage2:
                    return "stage2";
                case CocoonState.stage3:
                    return "stage3";
                default:
                    return "sleeping";
            }
        }

        public static CocoonState GetCocoonState(string cocoonState)
        {
            switch (cocoonState)
            {
                case "stage1" :
                    return CocoonState.stage1;
                case "stage2":
                    return CocoonState.stage2;
                case "stage3" :
                    return CocoonState.stage3;
                default:
                    return CocoonState.stage1;
            }
        }

        public CocoonStates()
        {

        }

        //public void FeedSi()
        //{
        //    Xp = Xp++;
        //}

    }
}
