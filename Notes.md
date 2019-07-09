# Production notes / scratch pad

*GameManager* *Snake* *Movement* *snakeArray*
Array for snake should be as long as the snake will ever be, values in movement will always be pushed down the array so at any given time the next tail section just needs to be set to active to become visible as it will already have an object with *Position* data.

### Bugs
``` Currently movement does not work, I think it has something to do with how position is being used, SFML says I should be able to just change position and it will render
 at the new location but that does not seem to be working? But I can check the objects and see the position changing. ```

``` Game Crashes after running for a short period with no errors```
