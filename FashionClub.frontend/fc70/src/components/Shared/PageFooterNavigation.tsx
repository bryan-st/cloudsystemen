import React from 'react';
import { Button } from 'react-bootstrap';

interface PageFooterNavigationProps {
    handleOnForward: () => void;
    handleOnBackwards: () => void;
}


const PageFooterNavigation: React.FC<PageFooterNavigationProps> = ({ handleOnForward, handleOnBackwards }) => {
    return (
        <>
            <div className="d-flex justify-content-between align-items-center mb-4 mt-4">
                <Button variant="secondary" onClick={handleOnBackwards}>
                    &larr; Terug
                </Button>

                <Button variant="success" onClick={handleOnForward}>
                    Opslaan en volgende &rarr;
                </Button>
            </div>
        </>
    );
};

export default PageFooterNavigation;