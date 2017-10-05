using UnityEngine;
using Patterns.Observer;

namespace Patterns.StateMachine
{
    public class StateMachine : MonoBehaviour, IObserver
    {
        public GameObject owner = null;
        public State state = null;

        protected virtual void Update()
        {
            state.OnStay();
        }

        public virtual void OnNotification(object sender, Message msg, params object[] args)
        {
            if (owner == null)
                return;

            if ((GameObject)sender == owner)
            {
                foreach (var t in state.transitions)
                {
                    if (t.trigger == msg)
                    {
                        t.source.OnExit();
                        state = t.target;
                        t.target.OnEnter();
                    }
                }
            }
        }

    }
}