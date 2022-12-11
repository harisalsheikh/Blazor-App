import csv
import json

csvFilePath = r'HyperCars2019.csv'
jsonFilePath = r'samplehypercar.json'

def csv_to_jsnon (csvFile, jsonFilePath):

    jsonArry = []

    with open (csvFilePath, encoding='utf-8') as csvf:

        csvReader = csv.DictReader(csvf)

        for row in csvReader:
            jsonArry.append(row)

    with open(jsonFilePath, 'w', encoding='utf-8') as jsonf: 
        jsonString = json.dumps(jsonArry, indent=4)
        jsonf.write(jsonString)


csv_to_jsnon(csvFilePath, jsonFilePath)
