﻿using System.Collections.Generic;

namespace ProjectBlue.FacialCapture.Core
{

    public enum ARKitBlendShape
    {
        noseSneer_R = 0,
        noseSneer_L = 1,
        mouthUpperUp_R = 2,
        mouthUpperUp_L = 3,
        mouthLowerDown_R = 4,
        mouthLowerDown_L = 5,
        mouthPress_R = 6,
        mouthPress_L = 7,
        mouthStretch_R = 8,
        mouthStretch_L = 9,
        mouth_R = 10,
        mouth_L = 11,
        mouthDimple_R = 12,
        mouthDimple_L =13,
        mouthFrown_R = 14,
        mouthFrown_L = 15,
        mouthFunnel = 16,
        mouthPucker = 17,
        mouthSmile_R = 18,
        mouthSmile_L = 19,
        mouthClose = 20,
        jaw_R = 21,
        jaw_L = 22,
        jawOpen = 23,
        jawForward = 24,
        eyeLookUp_R = 25,
        eyeLookUp_L = 26,
        eyeLookOut_R = 27,
        eyeLookOut_L = 28,
        eyeLookIn_R = 29,
        eyeLookIn_L = 30,
        eyeLookDown_R = 31,
        eyeLookDown_L = 32,
        eyeSquint_R = 33,
        eyeSquint_L = 34,
        eyeWide_R = 35,
        eyeWide_L = 36,
        eyeBlink_R = 37,
        eyeBlink_L = 38,
        cheekSquint_R = 39,
        cheekSquint_L = 40,
        cheekPuff = 41,
        browOuterUp_R = 42,
        browOuterUp_L = 43,
        browDown_R = 44,
        browDown_L = 45,
        browInnerUp = 46,
        tongueOut = 47,
        mouthRollLower = 48,
        mouthRollUpper = 49,
        mouthShrugLower = 50,
        mouthShrugUpper = 51
    }

    public class ARKitBlendShapeUtil
    {
        public static Dictionary<string, ARKitBlendShape> ARKitBlendShapeDictionary = new Dictionary<string, ARKitBlendShape>() {
            { EnumToString(ARKitBlendShape.noseSneer_R), ARKitBlendShape.noseSneer_R },
            { EnumToString(ARKitBlendShape.noseSneer_L), ARKitBlendShape.noseSneer_L },
            { EnumToString(ARKitBlendShape.mouthUpperUp_R), ARKitBlendShape.mouthUpperUp_R },
            { EnumToString(ARKitBlendShape.mouthUpperUp_L), ARKitBlendShape.mouthUpperUp_L },
            { EnumToString(ARKitBlendShape.mouthLowerDown_R), ARKitBlendShape.mouthLowerDown_R },
            { EnumToString(ARKitBlendShape.mouthLowerDown_L), ARKitBlendShape.mouthLowerDown_L },
            { EnumToString(ARKitBlendShape.mouthPress_R), ARKitBlendShape.mouthPress_R },
            { EnumToString(ARKitBlendShape.mouthPress_L), ARKitBlendShape.mouthPress_L },
            { EnumToString(ARKitBlendShape.mouthStretch_R), ARKitBlendShape.mouthStretch_R },
            { EnumToString(ARKitBlendShape.mouthStretch_L), ARKitBlendShape.mouthStretch_L },
            { EnumToString(ARKitBlendShape.mouth_R), ARKitBlendShape.mouth_R },
            { EnumToString(ARKitBlendShape.mouth_L), ARKitBlendShape.mouth_L },
            { EnumToString(ARKitBlendShape.mouthDimple_R), ARKitBlendShape.mouthDimple_R },
            { EnumToString(ARKitBlendShape.mouthDimple_L), ARKitBlendShape.mouthDimple_L },
            { EnumToString(ARKitBlendShape.mouthFrown_R), ARKitBlendShape.mouthFrown_R },
            { EnumToString(ARKitBlendShape.mouthFrown_L), ARKitBlendShape.mouthFrown_L },
            { EnumToString(ARKitBlendShape.mouthFunnel), ARKitBlendShape.mouthFunnel },
            { EnumToString(ARKitBlendShape.mouthPucker), ARKitBlendShape.mouthPucker },
            { EnumToString(ARKitBlendShape.mouthSmile_R), ARKitBlendShape.mouthSmile_R },
            { EnumToString(ARKitBlendShape.mouthSmile_L), ARKitBlendShape.mouthSmile_L },
            { EnumToString(ARKitBlendShape.mouthClose), ARKitBlendShape.mouthClose },
            { EnumToString(ARKitBlendShape.jaw_R), ARKitBlendShape.jaw_R },
            { EnumToString(ARKitBlendShape.jaw_L), ARKitBlendShape.jaw_L },
            { EnumToString(ARKitBlendShape.jawOpen), ARKitBlendShape.jawOpen },
            { EnumToString(ARKitBlendShape.jawForward), ARKitBlendShape.jawForward },
            { EnumToString(ARKitBlendShape.eyeLookUp_R), ARKitBlendShape.eyeLookUp_R },
            { EnumToString(ARKitBlendShape.eyeLookUp_L), ARKitBlendShape.eyeLookUp_L },
            { EnumToString(ARKitBlendShape.eyeLookOut_R), ARKitBlendShape.eyeLookOut_R },
            { EnumToString(ARKitBlendShape.eyeLookOut_L), ARKitBlendShape.eyeLookOut_L },
            { EnumToString(ARKitBlendShape.eyeLookIn_R), ARKitBlendShape.eyeLookIn_R },
            { EnumToString(ARKitBlendShape.eyeLookIn_L), ARKitBlendShape.eyeLookIn_L },
            { EnumToString(ARKitBlendShape.eyeLookDown_R), ARKitBlendShape.eyeLookDown_R },
            { EnumToString(ARKitBlendShape.eyeLookDown_L), ARKitBlendShape.eyeLookDown_L },
            { EnumToString(ARKitBlendShape.eyeSquint_R), ARKitBlendShape.eyeSquint_R },
            { EnumToString(ARKitBlendShape.eyeSquint_L), ARKitBlendShape.eyeSquint_L },
            { EnumToString(ARKitBlendShape.eyeWide_R), ARKitBlendShape.eyeWide_R },
            { EnumToString(ARKitBlendShape.eyeWide_L), ARKitBlendShape.eyeWide_L },
            { EnumToString(ARKitBlendShape.eyeBlink_R), ARKitBlendShape.eyeBlink_R },
            { EnumToString(ARKitBlendShape.eyeBlink_L), ARKitBlendShape.eyeBlink_L },
            { EnumToString(ARKitBlendShape.cheekSquint_R), ARKitBlendShape.cheekSquint_R },
            { EnumToString(ARKitBlendShape.cheekSquint_L), ARKitBlendShape.cheekSquint_L },
            { EnumToString(ARKitBlendShape.cheekPuff), ARKitBlendShape.cheekPuff },
            { EnumToString(ARKitBlendShape.browOuterUp_R), ARKitBlendShape.browOuterUp_R },
            { EnumToString(ARKitBlendShape.browOuterUp_L), ARKitBlendShape.browOuterUp_L },
            { EnumToString(ARKitBlendShape.browDown_R), ARKitBlendShape.browDown_R },
            { EnumToString(ARKitBlendShape.browDown_L), ARKitBlendShape.browDown_L },
            { EnumToString(ARKitBlendShape.browInnerUp), ARKitBlendShape.browInnerUp },
            { EnumToString(ARKitBlendShape.mouthRollLower), ARKitBlendShape.mouthRollLower},
            { EnumToString(ARKitBlendShape.mouthRollUpper), ARKitBlendShape.mouthRollUpper},
            { EnumToString(ARKitBlendShape.tongueOut), ARKitBlendShape.tongueOut},
            { EnumToString(ARKitBlendShape.mouthShrugLower), ARKitBlendShape.mouthShrugLower},
            { EnumToString(ARKitBlendShape.mouthShrugUpper), ARKitBlendShape.mouthShrugUpper}
        };

        static string EnumToString(ARKitBlendShape blendShapeType)
        {
            return blendShapeType.ToString().Replace("_L", "Left").Replace("_R", "Right").ToLower();
        }
    }
}