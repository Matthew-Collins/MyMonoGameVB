Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public Class MyGame
    Inherits Game

    Private Graphics As New GraphicsDeviceManager(Me)
    Private SpriteBatch As SpriteBatch

    Public Sub New()
    End Sub

    Protected Overrides Sub Initialize()
        MyBase.Initialize()
    End Sub

    Protected Overrides Sub LoadContent()
        Me.SpriteBatch = New SpriteBatch(Me.GraphicsDevice)
    End Sub

    Protected Overrides Sub UnloadContent()
    End Sub

    Protected Overrides Sub Update(gameTime As GameTime)
        MyBase.Update(gameTime)
    End Sub

    Protected Overrides Sub Draw(gameTime As GameTime)
        Me.GraphicsDevice.Clear(Color.CornflowerBlue)
        MyBase.Draw(gameTime)
    End Sub

End Class
