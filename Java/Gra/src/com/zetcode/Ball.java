package com.zetcode;

import java.awt.*;
import java.util.ArrayList;

public class Ball {
    int num;
    int x;
    int y;
    int radius = 15;
    Color color;
    Vector2D vector;

    Ball(int num, int x, int y, int radius, Color c, Vector2D vec) {
        this.num = num;
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

    @Override
    public String toString(){
        return "Ball " + Integer.toString(this.num);
    }

    /*
    Method checks whether border collision occurred
    and change velocity vector if needed
     */
    public void checkForBorderCollision(int borderWidth, int borderHeight){
        // Border collision
        if (this.x - this.radius <= 0)
        {
            this.x = this.radius;
            this.vector.x *= -1;
        }
        else if (this.x  + this.radius >= borderWidth)
        {
            this.x = borderWidth - this.radius;
            this.vector.x *= -1;
        }
        if (this.y - this.radius <= 0)
        {
            this.y = this.radius;
            this.vector.y *= -1;
        }
        else if (this.y + this.radius >= borderHeight)
        {
            this.y = borderHeight - this.radius;
            this.vector.y *= -1;
        }
    }

    public void checkForBallCollision(ArrayList<Ball> balls){
        int distance = 0;
        for(int i = 0; i < balls.size(); i++)
        {
            if (balls.get(i) != this)
            {
                Ball ball1 = this;
                Ball ball2 = balls.get(i);
                distance = computeDistance(ball1, ball2);
                if (distance <= (ball1.radius + ball2.radius))
                {
                    System.out.println("hello there");
                   Vector2D help;
                   help = ball1.vector;
                   ball1.vector = ball2.vector;
                   ball2.vector = help;
               }
            }
        }
    }

    public int computeDistance(Ball b1, Ball b2)
    {
        int vx = b1.x - b2.x;
        int vy = b1.y - b2.y;
        return (int)Math.sqrt(vx * vx + vy * vy);
    }
}
