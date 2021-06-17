from __future__ import division
import socket
import RPi.GPIO as gpio
import time
import numpy as np
from numpy import interp
import time
import Adafruit_PCA9685

gpio.setmode(gpio.BCM)

# Initialise the PCA9685 using the default address (0x40).
pwm = Adafruit_PCA9685.PCA9685()

# Set frequency to 60hz, good for servos.
pwm.set_pwm_freq(60)

HOST = '192.168.1.161'  # Standard loopback interface address (localhost)
PORT = 65432        # Port to listen on (non-privileged ports are > 1023)

lenkwinkel = '';
gas = '';
i_lenkwinkel = 0;
i_gas = 0;

with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
    s.bind((HOST, PORT))
    s.listen()
    conn, addr = s.accept()
    with conn:
        print('Connected by', addr)
        conn.sendall(b'Successfully connected with V1.1!')

        while True:
            try:
                data = conn.recv(1024)

                if data == b'LIGHTON':
                    #print("Turn on the light...")
                    conn.sendall(b'Turn on the light...')
                else:

                    if data == b'LIGHTOFF':
                        #print("Turn off the light...")
                        conn.sendall(b'Turn off the light...')
                    else:

                        if data == b'CALESC':
                            # Start PWM with 0% Duty Cycle
                            #p.start(0)
                            #ESC Kalibrierung starten
                            p.ChangeDutyCycle(0)
                            #print("Disconnect the battery and press Enter")
                            conn.sendall(b'Connect ESC now!')
                            conn.sendall(b'Motor high throttle')
                            p.ChangeDutyCycle(12.5)
                            #print("Connect ESC with battery now")
                            time.sleep(10)
                            p.ChangeDutyCycle(2.5)
                            #print ("Here comes the beep")
                            time.sleep(7)
                            #print ("Wait")
                            time.sleep (5)
                            #print ("Wait...")
                            p.ChangeDutyCycle(0)
                            time.sleep(2)
                            #print ("Start")
                            p.ChangeDutyCycle(7.5)
                            time.sleep(1)
                            #print ("Motor low throttle")
                            time.sleep(1)
                            #p.ChangeDutyCycle(0)
                            p.stop()
                            

                        else:
                            #print (data)
                            #b'' to string (Bytes to string)
                            data = data.decode("utf-8")
                            i_lenkwinkel = int(data[0:2])
                            i_gas = int(data[2:4])
                            #print (i_lenkwinkel)
                            #print (i_gas)
                            i_gas = interp(i_gas,[10,90],[150,600])
                            i_lenkwinkel = interp(i_lenkwinkel,[10,90],[150,600])
                            #print ("LW", i_lenkwinkel)
                            #print ("GA", i_gas)

                            #Writes out the values for throttle and steering to the servo
                            pwm.set_pwm(0, 0, int(i_lenkwinkel))
                            pwm.set_pwm(1, 0, int(i_gas))


                            if not data:
                                break
            except ConnectionResetError:
                #Jumps here when client disconnects -> Motor and steering stop
                pwm.set_pwm(0, 0, 150)