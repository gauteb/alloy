import React from 'react';
import TestProps from './props'

function Test(props: TestProps) {
    return (<h1>Hey {props.message}</h1>);
}

export default Test;