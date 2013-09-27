using System;
using Pos.UI.WinClient.WebUserService;

namespace Pos.UI.WinClient.Helpers
{
  public  class LoginEventArgs : EventArgs
    {
      public User User { get; set; }
    }
}
