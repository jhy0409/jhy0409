import pyautogui
import time

def refresh():
    pyautogui.hotkey('ctrl','r')

j = 7080

time.sleep(2)
for i in range(j, 7153):
    refresh()
    j += 1
    print(j)
    time.sleep(3)

# 11331