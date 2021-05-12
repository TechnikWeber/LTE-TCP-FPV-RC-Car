import socket
import RPi.GPIO as gpio
import time
from numpy import interp

servo = 12 #Pin12 Out PWM -> Acceleration(Motor)
servo2 = 13 #Pin13 Out PWM -> Steering
gpio.setmode(gpio.BCM)
gpio.setup(servo, gpio.OUT)
gpio.setup(servo2, gpio.OUT)

p = gpio.PWM(servo, 50)
p2 = gpio.PWM(servo2, 50)

# Start PWM with 0% Duty Cycle
p.start(0)
p2.start(0)

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
        conn.sendall(b'Successfully connected!')

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
                            i_gas = interp(i_gas,[10,90],[2.5,12.5])
                            i_lenkwinkel = interp(i_lenkwinkel,[10,90],[2.5,12.5])
                            print ("LW", i_lenkwinkel)
                            print ("GA", i_gas)

                            #Writes out the values for throttle and steering to the servo
                            p.ChangeDutyCycle(i_gas)
                            p2.ChangeDutyCycle(i_lenkwinkel)


                            if not data:
                                break
            except ConnectionResetError:
                #Jumps here when client disconnects -> Motor and steering stop
                p.ChangeDutyCycle(2.5)
                p2.ChangeDutyCycle(2.5)