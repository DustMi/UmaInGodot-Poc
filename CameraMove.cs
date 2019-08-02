using Godot;
using System;

public class CameraMove : Camera
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    float MOVE_SPEED = 1.0f;

    float xVelocity = 0.0f;
    float zVelocity = 0.0f;
    float yVelocity = 0.0f;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public override void _PhysicsProcess(float delta) {
        this.TranslateObjectLocal(new Vector3(xVelocity * delta, yVelocity * delta, zVelocity * delta));
    }

    public override void _UnhandledInput(InputEvent @event) {
        if(@event is InputEventKey eventKey) {
            if(eventKey.Scancode == (int)KeyList.W) {
                zVelocity = eventKey.Pressed ? -MOVE_SPEED : 0f;
            }
            else if(eventKey.Scancode == (int)KeyList.S) {
                zVelocity = eventKey.Pressed ? MOVE_SPEED : 0f;
            }
            else if(eventKey.Scancode == (int)KeyList.A) {
                xVelocity = eventKey.Pressed ? -MOVE_SPEED : 0f;
            }
            else if(eventKey.Scancode == (int)KeyList.D) {
                xVelocity = eventKey.Pressed ? MOVE_SPEED : 0f;
            }
            else if(eventKey.Scancode == (int)KeyList.E) {
                yVelocity = eventKey.Pressed ? MOVE_SPEED : 0f;
            }
            else if(eventKey.Scancode == (int)KeyList.Q) {
                yVelocity = eventKey.Pressed ? -MOVE_SPEED : 0f;
            }
        } else if(@event is InputEventMouseMotion inputEventMouseMotion) {
            GD.Print("Relative x: " + inputEventMouseMotion.Relative.x +
                    " Relative y: " + inputEventMouseMotion.Relative.y +
                    " Speed x: " + inputEventMouseMotion.Speed.x +
                    " Speed y: " + inputEventMouseMotion.Speed.y +
                    " Position x: " + inputEventMouseMotion.Position.x +
                    " Position y: " + inputEventMouseMotion.Position.y);
            this.RotateY(-inputEventMouseMotion.Speed.x/36000.0f);
            this.RotateX(-inputEventMouseMotion.Speed.y/36000.0f);
        }
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
