import pyautogui

file_a = pyautogui.locateOnScreen('A.PNG')
print(file_a)
pyautogui.click(file_a, duration=2)
# pip install Pillow



import time

start = time.time()
# print('start',start)
# time.sleep(3)
end = time.time()
# print('end',end)

# 10초동안 파일 이미지 찾기
def find_target(file_name,file_name2, timeout):
    while True:
        time.sleep(1)
        end = time.time()
        # print('end',end)
        
        file_a = pyautogui.locateOnScreen(file_name)
        # print(file_a)
        if file_a is not None :
            # print("찾음")
            # pyautogui.click(file_a, duration=2)
            return file_a

        file_b = pyautogui.locateOnScreen(file_name2)
        if file_b is not None :
                # print("찾음")
            # pyautogui.click(file_a, duration=2)
            return file_b

        if (end - start) > timeout:
            # print("10초 지남")
            break

k = 0
last = 3
# Ctrl C 강제종료
for i in range(0,last,1):
    box = find_target('A.PNG','B.PNG', 10)
    k += 1  
    print(k, "번째")
    pyautogui.click(box)
    pyautogui.moveTo(1000,300,duration=0.3)

    if (k==last):
        print(k, "번째 수행완료")