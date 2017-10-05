using System;
using System.Collections;
using UnityEngine;

namespace Patterns.Command
{
    public abstract class Command
    {

        public virtual void Execute(object target, params object[] args)
        {
            throw new NotImplementedException();
        }

        public virtual void Undo()
        {
            throw new NotImplementedException();
        }

    }

    public class NullCommand : Command
    {

        public override void Execute(object target, params object[] args)
        {
            Debug.LogError("Tried to execute null command!");
        }

    }
}