package com.zetcode;

import java.awt.*;

public class Ball {
    int x;
    int y;
    int radius = 15;
    Color color;
    Vector2D vector;

    Ball(int x, int y, int radius, Color c, Vector2D vec) {
        this.x = x;
        this.y = y;
        this.radius = radius;
        this.color = c;
        this.vector = vec;
    }
    Ball(){}

    // method moves single ball's x and y coordinates exactly
    // where ball.vector is pointing and checks if ball hit the
    // border
    public void moveBall(){
        this.x += this.vector.x;
        this.y += this.vector.y;
    }

    /*
    Method checks whether border collision occurred
    and change velocity vector if needed
     */
    public void checkForBorderCollision(int borderWidth, int borderHeight){
        // Border collision
        if (this.x - this.radius < 0)
        {
            this.x = this.radius;
            this.vector.x *= -1;
        }
        else if (this.x  + this.radius > borderWidth)
        {
            this.x = borderWidth - this.radius;
            this.vector.x *= -1;
        }
        if (this.y - this.radius < 0)
        {
            this.y = this.radius;
            this.vector.y *= -1;
        }
        else if (this.y + this.radius > borderHeight)
        {
            this.y = borderHeight - this.radius;
            this.vector.y *= -1;
        }
        // Other balls collision

    }
}
