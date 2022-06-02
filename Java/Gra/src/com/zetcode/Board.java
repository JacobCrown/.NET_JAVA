package com.zetcode;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.Toolkit;
import java.util.*;
import javax.swing.JPanel;

public class Board extends JPanel  {

    int NUM_OF_BALLS;
    private final int B_WIDTH = 960;
    private final int B_HEIGHT = 540;
    // private final int B_WIDTH = 200;
    // private final int B_HEIGHT = 200;
    private final int INITIAL_DELAY = 100;
    private final int PERIOD_INTERVAL = 25;
    private Random randomGenerator = new Random();
    private ArrayList<Ball> ballsList = new ArrayList<Ball>();
    private ArrayList<ThreadDemo> threadsList = new ArrayList<ThreadDemo>();
    private Timer timer;

    public Board(int ballsNum) {
        this.NUM_OF_BALLS = ballsNum;

        initBoard();
    }

    private void initBoard() {

        setBackground(Color.BLACK);
        setPreferredSize(new Dimension(B_WIDTH, B_HEIGHT));
        /*
        Here we need to set initial positions of balls
         */

        int width = B_WIDTH / (NUM_OF_BALLS + 1);
        int height = B_HEIGHT / (NUM_OF_BALLS + 1);
        int x = 0, y = 0;
        ArrayList<Color> colorsList = new ArrayList<Color>() {
            {
                add(Color.WHITE);
                add(Color.GREEN);
                add(Color.BLUE);
                add(Color.YELLOW);
                add(Color.RED);
            }
        };

        ArrayList<Integer> radiusList = new ArrayList<Integer>() {
            {
                add(20);
                add(25);
                add(30);
                add(40);
                add(50);
            }
        };

        int randNum = 5;

        for(int i = 0; i < NUM_OF_BALLS; i++)
        {
            x += width;
            y += height;
            // pick up random color
            int indexColor = randomGenerator.nextInt(colorsList.size());
            Color randomColor = colorsList.get(indexColor);
            // pick up random radius
            int indexRadius = randomGenerator.nextInt(colorsList.size());
            int randomRadius = radiusList.get(indexRadius);

            ballsList.add(new Ball(
                    i + 1,
                    x,
                    y,
                    randomRadius,
                    randomColor,
                    new Vector2D(
                            getRandomNumber(-randNum, randNum),
                            getRandomNumber(-randNum, randNum)
                    )
            ));
        }

        for(int i = 0; i < NUM_OF_BALLS; i++)
        {
            threadsList.add(new ThreadDemo(
                    ballsList.get(i).toString(),
                    ballsList.get(i)));
            threadsList.get(i).start();
        }

        timer = new Timer();
        timer.scheduleAtFixedRate(new ScheduleTask(),
                INITIAL_DELAY, PERIOD_INTERVAL);

    }

    public int getRandomNumber(int min, int max) {
        do {
            int num = (int) ((Math.random() * (max - min)) + min);
            if (num != 0)
                return num;
        } while (true);
    }

    @Override
    public void paintComponent(Graphics g) {
        super.paintComponent(g);

        drawBalls(g);
    }

    private void drawBalls(Graphics g) {

        for(Ball b: ballsList)
        {
            g.setColor(b.color);
            g.fillOval(b.x, b.y, b.radius, b.radius);
        }

        Toolkit.getDefaultToolkit().sync();
    }

    private class ScheduleTask extends TimerTask {

        @Override
        public void run() {

            repaint();

            for(Ball b: ballsList)
            {
                b.checkForBorderCollision(B_WIDTH, B_HEIGHT);
            }
            // after each ball moved check for ball to ball collision
            checkForBallCollision(ballsList);

        }
    }

    public void checkForBallCollision(ArrayList<Ball> balls)
    {
        int distance = 0;
        for(int i = 0; i < balls.size(); i++)
        {
            for(int j = i + 1; j < balls.size(); j++)
            {
                Ball ball1 = balls.get(i);
                Ball ball2 = balls.get(j);
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

    /*
    Method computes distance between 2 balls and their mass center
    */
    public int computeDistance(Ball b1, Ball b2)
    {
        int vx = b1.x - b2.x;
        int vy = b1.y - b2.y;
        return (int)Math.sqrt(vx * vx + vy * vy);
    }

    private class ThreadDemo extends Thread {
        private Thread t;
        private String threadName;
        Ball ball;

        ThreadDemo(String name, Ball ball) {
            threadName = name;
            this.ball = ball;
            System.out.println("Creating " + threadName);
        }

        public void run() {
            while(true){
                ball.moveBall();
                System.out.println(ball.toString() + " has moved");
                try
                {
                    Thread.sleep(8);
                }
                catch (InterruptedException ex)
                {
                    System.out.println("Thread " + threadName + " interrupted.");
                }
                repaint();
            }

            // try
            // {
            //     Thread.sleep(100);
            //     System.out.println("Running " + threadName);
            //     System.out.println("Thread " + threadName + " exiting.");
            // }
        }

        public void start() {
            System.out.println("Starting " + threadName);
            if (t == null) {
                t = new Thread(this, threadName);
                t.start();
            }
        }
    }

}