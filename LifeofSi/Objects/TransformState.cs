using System;
namespace LifeofSi.Objects
{
    public enum TransformState
    {
        stage1,
        stage2,
        stage3
    }

    class Transform
    {
        public static string GetTranformString(TransformState transformState)
          {
            switch (transformState)
            {
                case TransformState.stage1:
                    return "stage1";
                case TransformState.stage2:
                    return "stage2";
                case TransformState.stage3:
                    return "stage3";
                default:
                    return "Not active";
            }

        }

        public static TransformState GetTransformState(string transformString)
          {
            switch (transformString)
            {
                case "stage1":
                    return TransformState.stage1 ;
                case "stage2":
                    return TransformState.stage2;
                case "stage3":
                    return TransformState.stage3;
                default:
                    return TransformState.stage1;
            }

        }
    }
}
