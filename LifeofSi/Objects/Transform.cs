//using System;
//namespace LifeofSi.Objects
//{
//    public class Transform
//    {

//        const string transformStateKey = "transformState";

//        public TransformState CurrentTransformState
//        {
//            get
//            {
//                if (App.Current.Properties.ContainsKey(transformStateKey))
//                {
//                    return TransformState.GetTransformState((string)App.Current.Properties[transformStateKey];
//                }
//                else
//                {
//                    return TransformState.stage1;
//                }
//            }

//            set
//            {
//                App.Current.Properties[transformStateKey] = TransformState.GetTransformString(value);

//            }

//        }

//        public Transform()
//        {
//        }
//    }
//}
