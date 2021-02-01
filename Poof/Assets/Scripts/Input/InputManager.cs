using UnityEngine;

namespace myInput
{
    public static class InputManager
    {
#region Jump
        public static bool getJump()
        {
            return Input.GetKey(KeyBinds.jump) || Input.GetKey(KeyBinds.altJump);
        }

        public static bool getJumpDown()
        {
            return Input.GetKeyDown(KeyBinds.jump) || Input.GetKeyDown(KeyBinds.altJump);
        }

        public static bool getJumpUp()
        {
            return Input.GetKeyUp(KeyBinds.jump) || Input.GetKeyUp(KeyBinds.altJump);
        }
#endregion



        //crouch stuff
    }
}