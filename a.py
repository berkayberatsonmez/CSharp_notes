from sklearn.model_selection import train_test_split
from sklearn.feature_extraction.text import TfidfVectorizer
from sklearn.neighbors import NearestNeighbors
import numpy as np
import pandas as pd
# Veri setini yükle
df = pd.read_excel("Kitap2.xlsx")

# Soruları ve cevapları hazırla
questions = list(df["Questions"])
answers = list(df["Answer"])

# Veri setini eğitim ve test seti olarak ayır
X_train, X_test, y_train, y_test = train_test_split(questions, answers, test_size=0.2, random_state=42)

# TF-IDF modelini eğit
tfidf_vectorizer = TfidfVectorizer()
answer_vectors = tfidf_vectorizer.fit_transform(y_train)

# KNN modelini eğitin
knn = NearestNeighbors(n_neighbors=1, algorithm='auto').fit(answer_vectors)
# Tahmin yap
def get_similar_answer(question, data):
    question_vector = tfidf_vectorizer.transform([question])
    distances, indices = knn.kneighbors(question_vector)
    most_similar_question = questions[indices[0][0]]
    return data[indices[0][0]]

# Test setindeki her bir soru için gerçek cevabı ve tahmin edilen cevabı belirle
correct_predictions = 0
for i in range(len(X_test)):
    question = X_test[i]
    true_answer = y_test[i]
    predicted_answer = get_similar_answer(question, y_train)
    if true_answer == predicted_answer:
        correct_predictions += 1

# Doğruluk oranını hesapla
accuracy = correct_predictions / len(X_test)
print("Accuracy:", accuracy)
