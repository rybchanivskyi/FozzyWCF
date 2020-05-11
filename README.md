Задание по WCF:

Есть базовая конфигурация:
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <system.serviceModel>
        <behaviors>
            <serviceBehaviors>
                <behavior>
                    <serviceMetadata httpGetEnabled="True"/>
                </behavior>
            </serviceBehaviors>
        </behaviors>
    </system.serviceModel>
</configuration>


Необходимо:
В web.config выполнить следующее:
1.Добавить конечные точки BasicHttpBinding
2.Добавить конечные точки MEX
3.Добавить поведение метаданных (Metadata behavior)

В реализации сервиса под этот web.config:
1. Создание интерфейса.
2. Создание реализации службы.
3. Создание хоста.
4. Создание клиентского приложения.
