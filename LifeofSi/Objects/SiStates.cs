using System;
namespace LifeofSi.Objects
{
    public enum SiState
    {
        stage1,
        stage2,
        stage3
    }


    class SiStates
    {
        public static string GetSiString(SiState siState)
        {
            switch (siState)
            {
                case SiState.stage1:
                    return "stage1";
                case SiState.stage2:
                    return "stage2";
                case SiState.stage3:
                    return "stage3";
                default:
                    return "sleeping";
            }
        }

        public static SiState GetSiState(string siState)
        {
            switch (siState)
            {
                case "stage1" :
                    return SiState.stage1;
                case "stage2":
                    return SiState.stage2;
                case "stage3" :
                    return SiState.stage3;
                default:
                    return SiState.stage1;
            }
        }

        public SiStates()
        {

        }

    }
}
