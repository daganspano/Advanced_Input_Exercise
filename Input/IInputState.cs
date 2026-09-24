using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace CIS580.Input;

public interface IInputState
{
    public bool IsKeyPressed(Keys key);

    public bool IsNewKeyPress(Keys key);

    public bool IsButtonPressed(Buttons button, PlayerIndex? controllingPlayer, out PlayerIndex playerIndex);

    public bool IsNewButtonPress(Buttons button, PlayerIndex? controllingPlayer, out PlayerIndex playerIndex);
}