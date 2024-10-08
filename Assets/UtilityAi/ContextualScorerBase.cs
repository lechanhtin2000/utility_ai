﻿using UnityEngine;

namespace UtilityAI {
    public abstract class ContextualScorerBase : ScriptableObject {
        public AnimationCurve mapping = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));

        public float Score(IAIContext context) {
            var rawScore = RawScore(context);
            return mapping.Evaluate(rawScore);
        }

        protected abstract float RawScore(IAIContext context);
    }
}