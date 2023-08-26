Python 3.10.7 (tags/v3.10.7:6cc6b13, Sep  5 2022, 14:08:36) [MSC v.1933 64 bit (AMD64)] on win32
Type "help", "copyright", "credits" or "license()" for more information.
>>> 
... from sklearn.tree import DecisionTreeClassifier
... from sklearn.datasets import load_iris
... from sklearn.model_selection import train_test_split
... from sklearn.metrics import accuracy_score
... 
... # Cargar el conjunto de datos Iris
... iris = load_iris()
... X_train, X_test, y_train, y_test = train_test_split(iris.data, iris.target, test_size=0.2, random_state=42)
... 
... # Crear un clasificador de Árbol de Decisión
... clf = DecisionTreeClassifier()
... 
... # Entrenar el modelo
... clf.fit(X_train, y_train)
... 
... # Realizar predicciones en el conjunto de prueba
... predictions = clf.predict(X_test)
... 
... # Calcular la precisión
... accuracy = accuracy_score(y_test, predictions)
... print("Precisión del Árbol de Decisión:", accuracy)
