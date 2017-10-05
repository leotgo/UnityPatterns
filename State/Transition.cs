using Patterns.Observer;
using UnityEngine;

namespace Patterns.StateMachine
{
    [RequireComponent(typeof(State))]
    public class Transition : MonoBehaviour
    {
        public Message trigger;
        [HideInInspector] public State source;
        public State target;

        void Awake()
        {
            source = GetComponent<State>();
        }
    }
}