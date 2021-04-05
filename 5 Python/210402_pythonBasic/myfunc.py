import pyautogui
import time
import pyperclip

start = time.time()
end = time.time()

def doA():
    for i in range(0,5):
        print("i = ",i)

def han_write(text):
    pyperclip.copy(text)
    pyautogui.hotkey('ctrl','v')

# 10초동안 파일 이미지 찾기
def find_target(file_name,file_name2, timeout):
    while True:
        time.sleep(1)
        end = time.time()
        
        file_a = pyautogui.locateOnScreen(file_name)
        if file_a is not None :
            return file_a

        file_b = pyautogui.locateOnScreen(file_name2)
        if file_b is not None :
            return file_b

        if (end - start) > timeout:
            break

box = find_target('A.PNG','B.PNG', 10)
pyautogui.click(box)
pyautogui.moveTo(1000,300,duration=0.3)
