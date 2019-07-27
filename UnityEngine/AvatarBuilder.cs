using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
    /// <summary>
    ///   <para>Class to build avatars from user scripts.</para>
    /// </summary>
    public class AvatarBuilder
    {
        /// <summary>
        ///   <para>Create a humanoid avatar.</para>
        /// </summary>
        /// <param name="go">Root object of your transform hierachy. It must be the top most gameobject when you create the avatar.</param>
        /// <param name="humanDescription">Humanoid description of the avatar.</param>
        /// <returns>
        ///   <para>Returns the Avatar, you must always always check the avatar is valid before using it with Avatar.isValid.</para>
        /// </returns>
        public static Avatar BuildHumanAvatar(GameObject go, HumanDescription humanDescription)
        {
            if ((Object)go == (Object)null)
                throw new NullReferenceException();
            return AvatarBuilder.BuildHumanAvatarInternal(go, humanDescription);
        }

       
        private static Avatar BuildHumanAvatarInternal(GameObject go, HumanDescription humanDescription)
        {
            return AvatarBuilder.BuildHumanAvatarInternal_Injected(go, ref humanDescription);
        }

        public static Avatar BuildGenericAvatar( GameObject go, string rootMotionTransformName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///   <para>Create a new generic avatar.</para>
        /// </summary>
        /// <param name="go">Root object of your transform hierarchy.</param>

        //[MethodImpl(MethodImplOptions.InternalCall)]
        //public static extern Avatar BuildGenericAvatar([NotNull] GameObject go, [NotNull] string rootMotionTransformName);

        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern Avatar BuildHumanAvatarInternal_Injected(GameObject go, ref HumanDescription humanDescription);
    }
}
