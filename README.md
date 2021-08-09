Dan Newton's Bin

Here are some general scripts that have no real home.

SineWave (Unity/C#)
I needed a continuous timer function that was easy to adjust with difficulty settings, so I created a sine wave script that could be added to a gameobject and evaluated on a FixedUpdate() method or an Update() method.
My use case was for a Rhythm Game Jam that needed motion to be locked or unlocked depending on the beat of the song, and the timer script I was using was drifting due to frame rate.
Switching to the sine wave made sure that, unlike starting and restarting a timer, the function was continuous and based on the world time.
