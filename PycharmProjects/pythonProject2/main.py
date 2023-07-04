#пользователь вводит город, в котором определяется текущее время, вы задали переменную во сколько пришли на экзамен, выведите в консоль разницу этих двух времен
import datetime as dt

print("В Москве сейчас:")
utc_time = dt.datetime.utcnow()
period = dt.timedelta(hours=3)
moscow_time = utc_time + period
print(moscow_time)

UTC_OFFSET = {
    'Санкт-Петербург': 3,
    'Москва': 3,
    'Самара': 4,
    'Новосибирск': 7,
    'Екатеринбург': 5,
    'Нижний Новгород': 3,
    'Казань': 3,
    'Челябинск': 5,
    'Омск': 6,
    'Ростов-на-Дону': 3,
    'Уфа': 5,
    'Красноярск': 7,
    'Пермь': 5,
    'Воронеж': 3,
    'Волгоград': 3,
    'Краснодар': 3,
    'Калининград': 2,
    'Дзержинский': 3
}

city = input("Введите свой город: ")


def what_time(city):
    utc_time = dt.datetime.utcnow()
    period = dt.timedelta(hours=UTC_OFFSET[city])
    time = utc_time + period
    return time
print("В вашем городе сейчас:", (what_time(city)))

"""exam_year = input("Введите в каком году вы пришли на экзамен: ")
exam_mo = input("Введите в каком месяце вы пришли на экзамен: ")
exam_chislo = input("Введите какого числа вы пришли на экзамен: ")
exam_hour = input("Введите во сколько часов вы пришли на экзамен: ")
exam_minute = input("Введите во сколько минут вы пришли на экзамен: ")
exam_sek = input("Введите во сколько секунд вы пришли на экзамен: ")
exam_milisek = input("Введите во сколько милисекунд вы пришли на экзамен (6 цифр): ")

time_exam = dt.timedelta(exam_year, exam_mo, exam_chislo, exam_minute, exam_sek, exam_milisek)
def convert(time_exam):
    format = '%Y %m %d %H %M %S %f'
    datetime_str = dt.datetime.datetime.strptime(time_exam, format)

    return datetime_str
print(time_exam)"""


start_time = dt.datetime(2023, 7, 4, 9, 7, 0)
print('Вы пришли на экзамен', start_time)

raznica = what_time(city) - start_time
print("Разница между этими двумя датами: ", raznica)