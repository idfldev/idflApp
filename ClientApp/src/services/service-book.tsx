import { BOOK_URL } from "apis/api-path";
import axios from "axios";
import { useEffect, useState } from "react"

function ServiceBook() {
    const [data, setData] = useState([] || null);

    useEffect(() => {
        const handleResponse = async () => {
            try {
                const response = await axios.get(BOOK_URL);
                setData(response.data);
            } catch (error) {
                console.error("Error fetching data:", error);
            }
        };
        handleResponse();
    }, []);

    return data;
}

export default ServiceBook
