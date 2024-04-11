## API ##
All tanks extend from the `Tank` class. Two functions are overridden: `Update(Tank[] otherTanks)` and `Initalize()`.
`Update(Tank[] otherTanks)` is called every frame, 60 times a second.

The `Tank` class provides these methods to control your tank:
```csharp
// 1 for clockwise, -1 for counterclockwise
RotateBase(float amount);
// Rotates the turret of the tank similarly to RotateBase
RotateTurret(float amount);
// Accelerates forwards or backwards
Accelerate(float power);
// Calculates which direction to rotate towards a point, and rotates to it
RotateTowards(Vector2 location);
// Similar but only rotates turret
RotateTurretTowards(Vector2 location);
// Places the text above the tank. Useful for debugging.
Shout("Hello, World");
```
Each tank also has a set of public fields:
```csharp
Tank tank = GetTank();
Vector2 tankLocation = tank.Location;
float tankVelocity = tank.Velocity;
float tankRotationRad = tank.BaseRotation;
float tankTurretRotation = tank.TurretRotation;
TankColor color = tank.TankColor;
Weapon weapon = tank.Weapon;
string name = tank.Name;
```
Note: All units in pixels, and rotations are in radians.

### Example: ###
```csharp
internal class Rammer : Tank
{
    public override void Initalize()
    {
        TankColor = TankColor.Blue;
        Weapon = Weapon.Cannon;
    }

    public override void Update(Tank[] otherTanks)
    {
        if(otherTanks.Length != 0)
        {
            Tank tankToTarget = otherTanks[0].Location;
            Accelerate(1);
            RotateTowards(tankToTarget.Location);
            RotateTurretTowards(tankToTarget.Location);
            Shout(tankToTarget.Location.ToString());
        }            
    }
}
```
